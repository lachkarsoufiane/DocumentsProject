﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace DataModel;

public partial class DocumentsAuthorInfo
{

    public Guid Id { get; set; }

    public int NumId { get; set; }

    public Guid DocumentId { get; set; }

    public Guid AuthorId { get; set; }


    public virtual AuthorInfo Author { get; set; }


    public virtual DocumentInfo Document { get; set; }
}