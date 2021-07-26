using System;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;
using GHRepoAnalysisLib;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
 using System.Globalization;


public class RepoDataCsvMap: ClassMap<ModelDataLoder>
{
    public RepoDataCsvMap()
    {
        Map(mdl =>mdl.GHUserName).Name("GitHub_User Name");
        Map(mdl =>mdl.GHRepoName).Name("Repository Name");
        Map(mdl=>mdl.RepoInfo.full_name).Name("Repository Full Name");
        Map(mdl=>mdl.RepoInfo.name).Name("Repository Name");
        Map(mdl=>mdl.RepoInfo.id).Name("Repository ID");
        Map(mdl=>mdl.RepoInfo.node_id).Name("Repository Node ID");
        Map(mdl=>mdl.RepoInfo.created_at).Name("Repository Creation Date").TypeConverterOption.Format("s");
        Map(mdl=>mdl.RepoInfo.pushed_at).Name("Repository Push Date").TypeConverterOption.Format("s");
        Map(mdl=>mdl.RepoInfo.updated_at).Name("Repository Updated Date").TypeConverterOption.Format("s");
        Map(mdl=>mdl.RepoInfo.visibility).Name("Repository Visiblity");
        Map(mdl=>mdl.RepoInfo.stargazers_count).Name("Repository Stars");
        Map(mdl=>mdl.RepoInfo.watchers_count).Name("Repository Watchers");
        Map(mdl=>mdl.RepoInfo.forks_count).Name("Repository Fork");
        Map(mdl=>mdl.RepoInfo.language).Name("Repository Programing Languages");
        Map(mdl=>mdl.RepoInfo.Html_Url).Name("Repository Home Url");
        Map(mdl=>mdl.TotalIssueCount).Name("Repository Total Issues");
        Map(mdl=>mdl.OpenIssuesCount).Name("Repository Total Open Issues");
        Map(mdl=>mdl.TotalPullrequestCount).Name("Repository Total Pullrequest");
        Map(mdl=>mdl.OpenPullrequestCount).Name("Repository Total Open Pull request");
        Map(mdl=>mdl.ClosedPullrequestCount).Name("Repository Total Closed Pull request");
        Map(mdl=>mdl.ContributorsCount).Name("Repository Contributors");
        Map(mdl=>mdl.BranchNames).Name("Repository Branchs Name");

    }


    

    




    


    
}