﻿namespace EFCoreConsoleApp.Models;

public class Building
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}