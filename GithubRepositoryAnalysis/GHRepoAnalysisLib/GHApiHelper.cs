using System;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace GHRepoAnalysisLib
{
    public class GHApiHelper
    {
        
        public static RestClient GithubApiClient {get; set;}

        public string GHUserName { get; private set; }
        
        public string GHRepoName { get; private set; }

        private String _gHUserName;
        private String _gHRepoName;

        const string BaseUrl = "https://api.github.com/repos/";
        public  RestClient InitializeClient()
        {
            GithubApiClient = new RestClient(BaseUrl);

            GithubApiClient.AddDefaultHeader("ApiHeader", "application/vnd.github.v3+json");

            var reporequest = new RestRequest("{UserName}/{RepoName}").AddUrlSegment("UserName" , GHUserName );
         reporequest.AddUrlSegment("RepoName" , GHRepoName );
            return GithubApiClient;
            

        }

        public GHApiHelper(string gHRepoName , string gHUserName)
        {
            GHUserName= gHUserName;
            GHUserName= gHRepoName;
        }
        
        
        public static async Task<IRestResponse<T>> ExecuteAsyn<T> ( IRestRequest gHRequest ) where T: class , new()
        {
            var taskCompleatonSource = new TaskCompletionSource<IRestResponse<T>>();

            var response = await GithubApiClient.ExecuteGetAsync<T>(gHRequest);
            
            if(response.ErrorException != null)
            {   
                    //throw new Exception(response.ErrorMessage);
                const String Message = "Reponse Contain Error";
                throw new ApplicationException( Message , response.ErrorException);
            }

            taskCompleatonSource.SetResult(response);   
            return await taskCompleatonSource.Task;
        }


    }
}
