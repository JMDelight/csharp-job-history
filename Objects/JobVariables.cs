using System.Collections.Generic;
using System;
using System.Linq;

namespace JobHistory.Objects
{
  public class Job
  {
    private string _startDate;
    private string _employer;
    private string _title;
    private string _endDate;
    private static List<Job> _instances = new List<Job> {};
    private int _id;
    // public int StartDateSort{get; set;}

    public Job(string employer, string title, string startDate, string endDate)
    {
      _startDate = startDate;
      _employer = employer;
      _title = title;
      _endDate = endDate;
      _instances.Add(this);
      _id = _instances.Count;
    }
    // Getters for Job Object
    public string GetEmployer()
    {
      return _employer;
    }
    public string GetTitle()
    {
      return _title;
    }
    public string GetStartDate()
    {
      return _startDate;
    }
    public string GetEndDate()
    {
      return _endDate;
    }
    public static List<Job> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    // public int GetStartDateSort()
    // {
    //   return _startDateSort;
    // }
    // Searches for specific Job object and returns it
    public static Job Find(int searchId)
    {
      return _instances[searchId -1];
    }
    // public static void Sort()
    // {
    //   System.Console.WriteLine("Hello there");
      //
      // List<Job> sortedList = _instances.Sort(_instances);
      // _instances = sortedList;
    // }
    // Setters for Job object
    public void SetEmployer(string newEmployer)
    {
      _employer = newEmployer;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public void SetStartDate(string newStart)
    {
      _startDate = newStart;
      // Job.Sort();
      // StartDateSort = int.Parse(newStart.Replace("/", ""));
    }
    public void SetEndDate(string newEnd)
    {
      _endDate = newEnd;
    }

  }
}
