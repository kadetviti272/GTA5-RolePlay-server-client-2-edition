﻿using MpRpServer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MpRpServer.Data
{
    public class Character
    {
        public Character()
        {
            GroupMember = new List<GroupMember>();
            Property = new List<Property>();
            Vehicle = new List<Vehicle>();
        }

        [Key]
        public int Id { get; set; }

        public int OID { get; set; }

        public int Language { get; set; }
        // 1 - RUS; 2 - ENG;

        public string AccountId { get; set; }
        public IAccountData Account { get; set; }

        [StringLength(32)]
        public string Name { get; set; }

        public DateTime RegisterDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastLogoutDate { get; set; }
        public DateTime DebtDate { get; set; }
        public int RegistrationStep { get; set; }
        public bool Online { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Rot { get; set; }
        public int Model { get; set; }
        public int Admin { get; set; }

        [DefaultValue(0)]
        public int Level { get; set; }

        public int Age { get; set; }
        public int Cash { get; set; }
        public int Bank { get; set; }
        public int ActiveGroupID { get; set; }
        public int GroupType { get; set; }

        public int JobId { get; set; }
        public int PlayMinutes { get; set; }
        public int DriverLicense { get; set; }
        public string SocialClub { get; set; }
        public int TempVar { get; set; }
        public int Material { get; set; }

        public int ClothesTypes { get; set; }
        public int ActiveClothes { get; set; }
        public int Debt { get; set; }
        public int DebtLimit { get; set; }
        public int DebtMafia { get; set; }
        public int MafiaRoof { get; set; }

        public int Narco { get; set; }
        public int NarcoDep { get; set; }

        public DateTime NarcoHealDate { get; set; }
        public int NarcoHealQty { get; set; }

        public int PrisonTime { get; set; }
        public bool IsPrisoned { get; set; }

        public int MobilePhone { get; set; }

        // VOICE:
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public string player_voice_hash { get; set; }
        public string player_voice_rtc { get; set; }
        public int button_voice { get; set; }
        public int player_vehicle { get; set; }

        public virtual ICollection<GroupMember> GroupMember { get; set; }
        public virtual ICollection<Property> Property { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}


