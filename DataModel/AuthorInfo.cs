﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel;

public partial class AuthorInfo
{

    public Guid Id { get; set; }

    public int NumId { get; set; }


    public string Name { get; set; }


    public string Surname { get; set; }

    public virtual ICollection<DocumentsAuthorInfo> DocumentsAuthors { get; } = new List<DocumentsAuthorInfo>();
}