﻿namespace HRSystem.Csharp.Domain.Models.Task;

public class TaskCreateRequestModel
{
    public string? EmployeeCode { get; set; }

    public string? ProjectCode { get; set; }

    public string? TaskName { get; set; }

    public string? TaskDescription { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? TaskStatus { get; set; }

    public decimal? WorkingHour { get; set; }
}