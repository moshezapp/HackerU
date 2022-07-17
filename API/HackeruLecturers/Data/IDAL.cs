using HackeruLecturers.Models;
using System.Collections.Generic;

namespace HackeruLecturers.Data
{
    public interface IDAL
    {
        List<Language> GetAllLanguages();
        List<Lecturer> GetAllLectures();
    }
}