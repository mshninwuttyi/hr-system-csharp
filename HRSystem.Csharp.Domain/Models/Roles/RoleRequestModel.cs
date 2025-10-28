﻿namespace HRSystem.Csharp.Domain.Models.Roles;

public class RoleRequestModel
{
    public string? RoleName { get; set; }

    public string? RoleCode { get; set; }

    public string? UniqueName { get; set; }
}

public class RoleUpdateRequestModel
{
    public string? RoleName { get; set; }

    public string? UniqueName { get; set; }
}