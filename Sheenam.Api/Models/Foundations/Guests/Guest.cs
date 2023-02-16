//======================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free ToUse Comfort and Peace 
//======================


using System;

namespace Sheenam.Api.Models.Foundations.Guests
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string  FirstName{ get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBieth { get; set; }
        public string Emile { get; set; }
        public string PhoneNumber { get; set; }
        public string Adderss { get; set; }
        public GenderType Gender { get; set; }

    }
}
