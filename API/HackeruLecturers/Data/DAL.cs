using HackeruLecturers.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace HackeruLecturers.Data
{
    public class DAL : IDAL
    {
        private static List<Lecturer> _lecturers = null;
        private static List<Language> _languages = null;

        public DAL()
        {
        }

        public List<Lecturer> GetAllLectures()
        {
            if (_lecturers == null)
            {
                var path = Path.Combine(Environment.CurrentDirectory, @"Data\Lecturers.json");
                _lecturers = JsonConvert.DeserializeObject<List<Lecturer>>(File.ReadAllText(path));
            }

            return _lecturers;
        }

        public List<Language> GetAllLanguages()
        {
            if (_languages == null)
            {
                var path = Path.Combine(Environment.CurrentDirectory, @"Data\Languages.json");
                _languages = JsonConvert.DeserializeObject<List<Language>>(File.ReadAllText(path));
            }

            return _languages;
        }
    }
}
