﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkGenerator.Models
{
    public class ApplyJob
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Display(Name = "JobId")]
        public string JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

      
        [Display(Name = "Apply DetailsIs")]
        public int ApplyDetailsId { get; set; }

        [ForeignKey("ApplyDetailsId")]
        public virtual AppliedDetails AppliedDetails { get; set; }
        public bool Status { get; set; }

        [Display(Name = "Training")]
        public int TrainingId { get; set; }

        [ForeignKey("TrainingId")]
        public virtual Training Training { get; set; }
    }
}
