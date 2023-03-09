using DuongNguyenSongPhi_2011062999.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongNguyenSongPhi_2011062999.ViewModels
{
    public class CourseViewModel
    {
        private string place;
        private string date;
        private string time;
        private byte category;
        private IEnumerable<Category> categories;
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        public string Place { get => place; set => place = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public byte Category { get => category; set => category = value; }
        public IEnumerable<Category> Categories { get => categories; set => categories = value; }
    }
}