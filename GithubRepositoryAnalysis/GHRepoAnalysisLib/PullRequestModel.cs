using System;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;
using GHRepoAnalysisLib;


public class PullRequestModel
{
    // It is not yet determined
    public string[] Pull { get; set; }
    public string state { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}