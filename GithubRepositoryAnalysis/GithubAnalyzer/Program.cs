using System;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;
using GHRepoAnalysisLib;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
 using System.Globalization;


namespace GithubAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub Analyzer!");

            // if(args.Length !=2)
            // {
            //     System.Console.WriteLine("Two Argument Extected ");
            //     System.Console.WriteLine("First Extected Argument ist Github User Name ");
            //     System.Console.WriteLine("Second Extected Argument ist the Repository Name ");

            //     return;

            // }

            var username = "octocat";  //args[0]; for debuging 
            var reponame ="hello-world" ;  //args[1] for debuging


            
            var modelDataLoder = new ModelDataLoder(username , reponame);
            modelDataLoder.RepoDataModelloader();
            modelDataLoder.IssuePullDataModelLoader();
            modelDataLoder.BranchesModelDataLoader();
            modelDataLoder.ContributorModelDataLoader();

            var gHHelper= new GHApiHelper();
            gHHelper.GetHashCode();
            

        }

    }  
}
