﻿using exercise.wwwapi.DataModels;
using exercise.wwwapi.DataModels.DTOs;

namespace exercise.wwwapi.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<IEnumerable<Course>> GetCourses();
        Task<Course> AddCourse(Course course);
        Task<Course> UpdateCourse(PatchCourseDTO course, int id);
        Task<Course> DeleteCourse(int id);
    }

}
