﻿using Microsoft.EntityFrameworkCore;
using Shared.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trainer.EF
{
    public class TestRepository: Repository<Movies, int>
    {
        public TestRepository(DbContext context): base(context)
        {

        }
    }
}
