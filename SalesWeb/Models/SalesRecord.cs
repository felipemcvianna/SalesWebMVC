﻿using SalesWeb.Models.Enumables;

namespace SalesWeb.Models;

public class SalesRecord
{
    public int  Id { get; set; }
    public DateTime Data { get; set; }
    public double Amount { get; set; }
    public ESalesStatus Status { get; set; }
    public Seller Seller { get; set; }

    public SalesRecord()
    {
        
    }

    public SalesRecord(int id, DateTime data, double amount, ESalesStatus status, Seller seller)
    {
        Id = id;
        Data = data;
        Amount = amount;
        Status = status;
        Seller = seller;
    }
}