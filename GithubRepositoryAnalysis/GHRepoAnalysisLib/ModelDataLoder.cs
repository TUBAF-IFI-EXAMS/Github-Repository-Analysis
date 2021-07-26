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

        public String BaseRequest{get; set;}

        public RepoDataModel RepoInfo {get; set;}

        public List<string> BranchNames { get; set; }

        public int BranchsCount { get; set; }

        public int ContributorsCount { get; set; }
        //public IssueAndPullModel issuePullInfo { get; set; }

        public int TotalIssueCount { get; set; }

        public int OpenIssuesCount { get; set; }
        public int ClosedIssuesCount { get; set; }

        public int TotalPullrequestCount { get; set; }

        public int OpenPullrequestCount { get; set; }
        public int ClosedPullrequestCount { get; set; }



        public ModelDataLoder(string username , string reponame)
        {
            GHRepoName = reponame;
            GHUserName = username;
            BaseRequest = $"{username}/{reponame}";
        }

        
        RestClient gitclient = GHApiHelper.InitializeClient();

        
    	public ModelDataLoder()
        {

        }
        
        public void RepoDataModelloader ()
        {   
            
            var reporequest = new RestRequest(BaseRequest);

            var response = GHApiHelper.ExecuteAsynRequest<RepoDataModel>(reporequest).GetAwaiter().GetResult();

            
            
            System.Console.WriteLine($"the repo id :  {response.Data.id}");
            System.Console.WriteLine($"the repo Description :  {response.Data.description}");

            RepoInfo=response.Data;
            
        }

        public void IssuePullDataModelLoader()
        {   
            int IssuesPageNumber=1;
            int OpenPull=0;
            int openIssues=0;
            int closedPull=0;
            int closedIssues=0;
            //int issueCount=0;
            bool IsIssueAvailable= true;
            do
            {   
                
                var ispRequest = new RestRequest(BaseRequest+"/{Issues}").AddUrlSegment("Issues" , "issues");
                ispRequest.AddParameter("state" , "all");
                ispRequest.AddParameter("page", IssuesPageNumber);
                ispRequest.AddParameter("per_page" , 100);
            var response = GHApiHelper.ExecuteAsynRequest<List<IssueAndPullModel>>(ispRequest).GetAwaiter().GetResult();

            foreach (IssueAndPullModel issueOrPull in response.Data)
            {
                if (issueOrPull.state=="open")
                {
                    if(issueOrPull.pull_request is not  null)
                    {
                        OpenPull++;
                    }
                    else
                    {
                        openIssues++;
                    }
                }
                else
                {
                    if(issueOrPull.pull_request is not  null)
                    {
                        closedPull++;
                    }
                    else
                    {
                        closedIssues++;
                    }
                }



            }
            
            if(response.Data.Count==0)
            {
                IsIssueAvailable=false;
            }
            else
            {   
                
                IssuesPageNumber++;
                
            }

            

            } while (IsIssueAvailable !=false);


            TotalIssueCount= openIssues+closedIssues;
            System.Console.WriteLine($"Total  Issue {TotalIssueCount}");
            TotalPullrequestCount= OpenPull + closedPull;
            System.Console.WriteLine($"Total  Pull requests {TotalPullrequestCount}");

            
            OpenIssuesCount=openIssues;
            System.Console.WriteLine($"Open Issue {openIssues}");

            
            OpenPullrequestCount=OpenPull;
            System.Console.WriteLine($"Open Pull request {OpenPull}");
            
            
            ClosedIssuesCount=closedIssues;
            System.Console.WriteLine($"Closed Issue {closedIssues}");
            
            ClosedPullrequestCount=closedPull;
            System.Console.WriteLine($"Closed Pull request {closedPull}");


            
           

        }

        public void ContributorModelDataLoader()
        {   
            int conbtPageNumber=1;
            int conbts=0;
            bool IsContributorAvailable= true;
          
            do
            {
                var ispRequest = new RestRequest(BaseRequest+"/{Contributors").AddUrlSegment("Contributors" , "contributors");
                
                ispRequest.AddParameter("page", conbtPageNumber);
                ispRequest.AddParameter("per_page" , 100);
                var response = GHApiHelper.ExecuteAsynRequest<List<ContributorsModel>>(ispRequest).GetAwaiter().GetResult();
                
                
                conbts= response.Data.Count;

                //Check Number of contributors
                if(conbts==0)
                {
                    IsContributorAvailable=false;
                }
                else
                {   
                    
                    conbtPageNumber++;
                    conbts++;
                    
                }
                


            } while (IsContributorAvailable !=false);

            
            ContributorsCount=conbts;
            System.Console.WriteLine($"Number of contributors {conbts}");
        }

        public void BranchesModelDataLoader()
        {
            List<string> branchName = new List<string>() ;
            //int branchesCount;
            var ispRequest = new RestRequest(BaseRequest+"/{Branches}").AddUrlSegment("Branches" , "branches");
            var response = GHApiHelper.ExecuteAsynRequest<List<BranchesModel>>(ispRequest).GetAwaiter().GetResult();

            foreach (BranchesModel item in response.Data)
            {
                
                branchName.Add(item.name);

                System.Console.WriteLine($" Baranch Name {item.name}");
                
            }
            BranchNames=branchName;

            var BranchesCount= response.Data.Count;
            
            BranchsCount =BranchesCount;

            System.Console.WriteLine($" Baranch Name {BranchesCount}");

        }
        



    }