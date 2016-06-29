using Nancy;
using System.Collections.Generic;
using JobHistory.Objects;

namespace JobHistory
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml"];
      };
      Get["/jobs"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["view_jobs.cshtml", allJobs];
      };
      Get["/jobs/new"] = _ => {
        return View["add_job.cshtml"];
      };
      Post["/jobs"] = _ => {
        Job newJob = new Job(Request.Form["new-employer"], Request.Form["new-title"], Request.Form["new-start-date"], Request.Form["new-end-date"]);
        List<Job> allJobs = Job.GetAll();
        return View["view_jobs.cshtml", allJobs];
      };
      Get["/job/details/{id}"] = parameters => {
        Job job = Job.Find(parameters.id);
        return View["/view_details.cshtml", job];
      };
      Get["/job/details/edit/{id}"] = parameters => {
        Job job = Job.Find(parameters.id);
        return View["/edit_job.cshtml", job];
      };
      Post["/job/details/{id}"] = parameters => {
        Job job = Job.Find(parameters.id);
        job.SetEmployer(Request.Form["new-employer"]);
        job.SetTitle(Request.Form["new-title"]);
        job.SetStartDate(Request.Form["new-start-date"]);
        job.SetEndDate(Request.Form["new-end-date"]);
        return View["/view_details.cshtml", job];
      };
    }
  }
}
