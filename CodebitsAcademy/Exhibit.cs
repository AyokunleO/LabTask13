using System;
using System.Collections.Generic;
using System.Collections;

namespace CodebitsAcademy
{
    public class Exhibit
    {
        public string ExhibitName { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string Floor { get; set; }
        public string BuildingName { get; set; }

        public Exhibit(string exhibitName, string studentName, string subjectName, string floor, string buildingName)
        {
            ExhibitName = exhibitName;
            StudentName = studentName;
            SubjectName = subjectName;
            Floor = floor;
            BuildingName = buildingName;
        }

        public override string ToString()
        {
            return $"Exhibit Name: {ExhibitName}\tName of Student: {StudentName}\tSubject: {SubjectName}\tFloor: {Floor}\tBuilding Name: {BuildingName}\n";
        }
    }
}