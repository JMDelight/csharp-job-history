using System.Collections.Generic;

namespace JobHistory.Objects
{
  public class Job
  {
    private string _employer;
    private string _title;
    private string _startDate;
    private string _endDate;
    private static List<Job> _instances = new List<Job> {};
    private int _id;
    private int _startDateSort;

    public Job(string employer, string title, string startDate, string endDate)
    {
      _employer = employer;
      _title = title;
      _startDate = startDate;
      _endDate = endDate;
      _instances.Add(this);
      _id = _instances.Count;
      _startDateSort = int.Parse(startDate.Replace("/", ""));
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
    public int GetStartDateSort()
    {
      return _startDateSort;
    }
    // Searches for specific Job object and returns it
    public static Job Find(int searchId)
    {
      return _instances[searchId -1];
    }
    public static void Sort
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
      _startDateSort = int.Parse(newStart.Replace("/", ""));
    }
    public void SetEndDate(string newEnd)
    {
      _endDate = newEnd;
    }
  }
}
