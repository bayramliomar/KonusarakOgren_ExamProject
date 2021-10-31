﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InterviewProject.Entities.Entities
{
    public partial class AspNetUserClaim
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
