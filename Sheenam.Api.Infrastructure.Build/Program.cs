//======================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free ToUse Comfort and Peace 
//======================

using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

var githubPipeline = new GithubPipeline
{
    Name = "Sheenam Build Pipeline",

    OnEvents = new Events
    {

        PullRequest = new PullRequestEvent
        {
            Branches = new string[] { "Main" }
        },

        Push = new PushEvent
        {
            Branches = new string[] { "Main" }
        }
    },

    Jobs = new Jobs
    {
        Build = new BuildJob
        {
            RunsOn = BuildMachines.Windows2022,

            Steps = new List<GithubTask>
            {

             new CheckoutTaskV2
             {
                 Name = "Checking out code"
             },

             new SetupDotNetTaskV1
             {
                 Name = "Seting Up .Net",

                 TargetDotNetVersion = new TargetDotNetVersion
                 {
                     DotNetVersion = " 6.0.405"
                 }
             },

             new RestoreTask
             {
               Name ="Restoring Nuget Pasckages"
             },

             new DotNetBuildTask
             {
                 Name ="Building Project"
             },

             new TestTask
             {
                Name = "Running Tests"
             }

            }
        }
    }

};

var clinet = new ADotNetClient();

clinet.SerializeAndWriteToFile(
    adoPipeline:githubPipeline,
    path: "../../../../.github/workflows/dotnet.yml");