/*
==============================================================================
Megapayment Internet Portal
Copyright (c) 2010 VNPT ePay JSC
==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

public static class helper {

  /**
   * Initialise data
   */
  public static void init() {
    //
  }

  /**
   * Print a string
   * @param string text The text to print
   */
  public static void print(string text) {
    HttpContext.Current.Response.Write(text);
  }


  /// <summary>
  /// Kiem tra danh sach so dien thoai nhap vao codung khong
  /// </summary>
  /// <param name="phone_string"></param>
  /// <returns></returns>
  public static bool valid_phone_number(string phone_string)
  {
      string[] phonetmp = phone_string.Split(",".ToCharArray());
      for (int i = 0; i < phonetmp.Length; i++)
      {
          try
          {
              if (phonetmp[i] == null)
              {
                  
                  return false;
              }
              else if (phonetmp[i].Length < 10 || phonetmp[i].Length>11)
              {                  
                  return false;
              }
              else if (IsNumber(phonetmp[i]) == false)
              {                  
                  return false;
              }
          }
          catch
          {
              return false;

          }
      }
      return true;
  }
  /**
   * Prepare data
   */
  public static bool IsNumber(string pValue)
  {
      foreach (Char c in pValue)
      {
          if (!Char.IsDigit(c))
              return false;
      }
      return true;
  }
  /**
   * Print an object
   * @param Object obj The obj to print
   */
  public static void print(Object obj) {
    HttpContext.Current.Response.Write(obj);
  }  
  
  /**
   * Get absolute path on hard-disk of website
   * @return string Absolute path, eg. 'c:/localhost/some/path/'
   */
  public static string get_root_path() {
    return HttpContext.Current.Server.MapPath("~")+"\\";
	
  }
  
  /**
   * Get MD5 of string
   * @param string source_str
   * @return string The md5 encoded string
   */
  public static string md5(string source_str) {
    MD5 encrypter = new MD5CryptoServiceProvider();  
    Byte[] original_bytes = ASCIIEncoding.Default.GetBytes(source_str);
    Byte[] encoded_bytes = encrypter.ComputeHash(original_bytes);
    return BitConverter.ToString(encoded_bytes).Replace("-","").ToLower();
  }
  
  /**
   * Alphanumeric format a string
   * @param string source_str
   * @return string
   */
  public static string alphanum(string source_str) {
    Regex rule = new Regex("[^a-zA-Z0-9 ]");
    return rule.Replace(source_str,"").Trim();  
  }
  
  /**
   * Format a string, keep only alphabet chars
   * @param string source_str
   * @return string
   */
  public static string alphabet(string source_str) {
    Regex rule = new Regex("[^a-zA-Z ]");
    return rule.Replace(source_str,"").Trim();  
  }  
  
  /**
   * Trim unnecessary spaces
   * @param string source
   * @return string The trimmed source
   */
  public static string trim_inner(string source) {
    while (source.Contains("  "))
      source.Replace("  "," ");
    return source;
  }
  
  /**
   * Get current page file name
   * @return string 
   */
  public static string get_page_file() {
    return Path.GetFileName(HttpContext.Current.Request.Path);
  }
  
  /**
   * Get file extension
   * @param string file_name The full file name
   * @return string The extension of file including '.' in front
   */
  public static string get_file_extension(string file_name) {
    return System.IO.Path.GetExtension(file_name);
  }
  
  /**
   * Dump to file (for debugging)
   */
  public static void dump(string text) {
    string root_path = get_root_path();
    TextWriter writer = new StreamWriter(root_path+"dump.txt");
    writer.Write(text);
    writer.Close();
  }  
  
  /**
   * Save a recent action
   * @param string issuer The issuer (partner) code
   * @param string user The user from issuer
   * @param string name The name of accessed page
   * @param string page The url to page (file name .aspx)
   * @param SortedList params The params to be included in url
   */
   /*
  public static void save_action(string issuer,string user,
      string name,string page,SortedList params_obj) {
    if (issuer==null || user==null || issuer.Length==0 || user.Length==0)
      return;
      
    //make string for params in url
    string params_str = "";
    foreach (DictionaryEntry entry in params_obj)
      params_str += entry.Key.ToString()+"="+entry.Value.ToString()+"&";
    params_str = params_str.Trim();
    if (params_str.Length>0)
      params_str = params_str.Substring(0,params_str.Length-1);
  
    //make query string
    int next_id = oracle.get_next_id("mp_recents");
    string sql = null;
    sql = "insert into mp_recents (id,issuer,subscriber,name,page,params) "+
        "values (:id,:issuer,:subscriber,:name,:page,:params)";
        
    //add sql params    
    SortedList vars = new SortedList();
    vars.Add("id",next_id);
    vars.Add("issuer",issuer);
    vars.Add("subscriber",user);
    vars.Add("name",name);
    vars.Add("page",page);
    vars.Add("params",params_str);
    
    //query
    oracle.query_ex(sql,vars);
  }    */
}