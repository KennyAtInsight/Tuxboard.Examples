﻿using System.Text.Json.Serialization;

namespace Models;

public class AdvancedLayoutItem
{
    public Guid LayoutRowId { get; set; }
    public int Index { get; set; }
    public int TypeId { get; set; }
}