﻿using BotTools.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotTools
{
    public sealed class Permissions
    {
        [JsonIgnore]
        public static readonly string PermissionsFilePath = @"Config\permissions.json";
        [JsonIgnore]
        public static readonly string ConfigFolderPath = @"Config\";

        public List<PermissionGroup> Groups = new List<PermissionGroup>();
        public static Permissions Instance { get; private set; }

        public static void CreateConfigIfNotExist()
        {
            if (!Directory.Exists(ConfigFolderPath))
                Directory.CreateDirectory(ConfigFolderPath);
            if (!File.Exists(PermissionsFilePath))
            {
                File.AppendAllText(PermissionsFilePath, JsonConvert.SerializeObject(new Permissions
                {
                    Groups =
                    {
                        new PermissionGroup{ GroupName = "default"},
                        new PermissionGroup{ GroupName = "admin"}
                    }
                }, Formatting.Indented));
            }
        }

        private static string ReadPermissionsFile()
        {
            CreateConfigIfNotExist();
            return File.ReadAllText(PermissionsFilePath);
        }

        public static void Load()
        {
            CreateConfigIfNotExist();
            Instance = new Permissions();
            JsonConvert.PopulateObject(ReadPermissionsFile(), Instance);
        }

        public static void PrintAllPermissionValues(Permissions p)
        {
            foreach (var group in p.Groups)
            {
                Logger.Log(group.GroupName);
                foreach (var mem in group.Members)
                    Logger.Log("   Member: " + mem);
                foreach (var cmd in group.Commands)
                    Logger.Log("   Command: " + cmd);
            }
        }
    }

    public class PermissionGroup
    {
        public string GroupName;
        public List<string> Members = new List<string> { };
        public List<string> Commands = new List<string> { };
    }
}
