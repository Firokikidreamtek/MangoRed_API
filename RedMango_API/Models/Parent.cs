using Newtonsoft.Json;

namespace RedMango_API.Models
{
    [System.Serializable]
    public class Parent
    {
        [JsonProperty("data")] private Data _data;
        [JsonProperty("success")] private bool _success;
        [JsonProperty("status")] private int _status;

        public Data Data
        {
            get { return _data; }
        }

        public bool Success
        {
            get { return _success; }
        }

        public int Status
        {
            get { return _status; }
        }
    }

    [System.Serializable]
    public class Data
    {
        [JsonProperty("id")] private string _id;
        [JsonProperty("title")] private string _title;
        [JsonProperty("url_viewer")] private string _urlViewer;
        [JsonProperty("url")] private string _url;
        [JsonProperty("display_url")] private string _displayUrl;
        [JsonProperty("width")] private string _width;
        [JsonProperty("height")] private string _height;
        [JsonProperty("size")] private string _size;
        [JsonProperty("time")] private string _time;
        [JsonProperty("expiration")] private string _expiration;
        [JsonProperty("image")] private Image _image;
        [JsonProperty("thumb")] private Thumb _thumb;
        [JsonProperty("medium")] private Medium _medium;
        [JsonProperty("delete_url")] private string _deleteUrl;

        public string Id
        {
            get { return _id; }
        }

        public string Title
        {
            get { return _title; }
        }

        public string UrlViewer
        {
            get { return _urlViewer; }
        }

        public string Url
        {
            get { return _url; }
        }

        public string DisplayUrl
        {
            get { return _displayUrl; }
        }

        public string Width
        {
            get { return _width; }
        }

        public string Height
        {
            get { return _height; }
        }

        public string Size
        {
            get { return _size; }
        }

        public string Time
        {
            get { return _time; }
        }

        public string Expiration
        {
            get { return _expiration; }
        }

        public Image Image
        {
            get { return _image; }
        }

        public Thumb Thumb
        {
            get { return _thumb; }
        }

        public Medium Medium
        {
            get { return _medium; }
        }

        public string DeleteUrl
        {
            get { return _deleteUrl; }
        }
    }

    [System.Serializable]
    public class Image
    {
        [JsonProperty("filename")] private string _filename;
        [JsonProperty("name")] private string _name;
        [JsonProperty("mime")] private string _mime;
        [JsonProperty("extension")] private string _extension;
        [JsonProperty("url")] private string _url;

        public string Filename
        {
            get { return _filename; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Mime
        {
            get { return _mime; }
        }

        public string Extension
        {
            get { return _extension; }
        }

        public string Url
        {
            get { return _url; }
        }
    }

    [System.Serializable]
    public class Thumb
    {
        [JsonProperty("filename")] private string _filename;
        [JsonProperty("name")] private string _name;
        [JsonProperty("mime")] private string _mime;
        [JsonProperty("extension")] private string _extension;
        [JsonProperty("url")] private string _url;

        public string Filename
        {
            get { return _filename; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Mime
        {
            get { return _mime; }
        }

        public string Extension
        {
            get { return _extension; }
        }

        public string Url
        {
            get { return _url; }
        }
    }

    [System.Serializable]
    public class Medium
    {
        [JsonProperty("filename")] private string _filename;
        [JsonProperty("name")] private string _name;
        [JsonProperty("mime")] private string _mime;
        [JsonProperty("extension")] private string _extension;
        [JsonProperty("url")] private string _url;

        public string Filename
        {
            get { return _filename; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Mime
        {
            get { return _mime; }
        }

        public string Extension
        {
            get { return _extension; }
        }

        public string Url
        {
            get { return _url; }
        }
    }
}
