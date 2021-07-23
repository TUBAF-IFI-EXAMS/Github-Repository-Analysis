using System;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

using GHRepoAnalysisLib;

public  class ModelDataLoder
    {
         public string GHRepoName { get; set; }

        public string GHUserName { get; set; }


        public ModelDataLoder(string username , string reponame)
        {
            GHRepoName = reponame;
            GHUserName = username;
        }

        
        RestClient gitclient = GHApiHelper.InitializeClient();

        
    	public ModelDataLoder()
        {

        }
        
        public void RepoDataModelloader ()
        {   
            
            var reporequest = new RestRequest("{UserName}/{RepoName}").AddUrlSegment("UserName" , GHUserName );
                reporequest.AddUrlSegment("RepoName" , GHRepoName );
            var response = gitclient.ExecuteAsync<RepoDataModel>(reporequest).GetAwaiter().GetResult();
            var id = response.Data.id;

            System.Console.WriteLine($"the repo id is {id}");
            System.Console.WriteLine($"the repo Description is {response.Data.description}");
        }




    }