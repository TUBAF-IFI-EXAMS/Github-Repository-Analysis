using System;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;
using GHRepoAnalysisLib;

public class RepoDataModel
{
    public int id { get; set; }

    public string node_id { get; set; }
    public string name { get; set; }

    public string full_name { get; set; }

    public string description { get; set; }
    public string Html_Url { get; set; }
    public string language { get; set; }
    public uint forks_count { get; set; }
    public uint stargazers_count { get; set; }

    public uint watchers_count { get; set; }

    public uint open_issues_count { get; set; }
    public string visibility { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime pushed_at { get; set; }
}