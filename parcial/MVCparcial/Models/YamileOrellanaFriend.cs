﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MVCparcial.Models
{
    public enum TipoUnidad
    {
        Conocido,
        CompañeroEstudio,
        ColegadeTrabajo,
        Amigo,
        AmigodeInfancia,
        Pariente
    }
    
    public class YamileOrellanaFriend
    {
        [Key]
        public int FriendId { get; set; }  //prop+tab tab
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthdate { get; set; }
        [Required]
        public TipoUnidad Unidad { get; set; }
       
    }
}