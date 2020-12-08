﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
  //Omer's class

/*  class Meeting
  {
    public string MeetingInitiator { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string[] Guests { get; set; }
    public string[] Equipment { get; set; }
    public string MeetingDescription { get; set; }

    private string meetingIniator;
    private string date;
    private string time;
    private string[] guests;
    private string[] equipment;
    private string meetingDescrption;

  }*/

  class Meeting
  {


    // attributes
    private string meetingInitiator;
    private string title;
    private DateTime timeDate;
    private string[] guests = new string[10];
    private string[] equipment = new string[5];
    private string meetingDescription;
    private string location;
    private UserType importanceLevel;
    public Meeting(string meetingTitle, string initiator, string[] possibleGuests, DateTime date, string[] Equipment, string description, string meetingLocation, UserType type)
    {
      // constructor
      title = meetingTitle;
      meetingInitiator = initiator;
      guests = possibleGuests;
      timeDate = date;
      equipment = Equipment;
      meetingDescription = description;
      location = meetingLocation;
      importanceLevel = type;

      //location
    }
    public Meeting()
    {
      meetingInitiator = "<enter name>";
      DateTime timeDate = new DateTime(2020, 3, 1, 7, 0, 0);
      meetingDescription = "";
      importanceLevel = UserType.Five;

    }
    // working getters and setters for every attribute
    public string Initiator
    {
      get
      {
        return meetingInitiator;
      }
      set
      {
        meetingInitiator = value;
      }
    }
    public String[] Guests
    {
      get
      {
        return guests;
      }
      set
      {
        guests = value;
      }
    }
    public DateTime Date
    {
      get
      {
        return timeDate;
      }
      set
      {
        timeDate = value;
      }
    }
    public String[] Equipment
    {
      get
      {
        return equipment;
      }
      set
      {
        equipment = value;
      }
    }
    public string Description
    {
      get
      {
        return meetingDescription;
      }
      set
      {
        meetingDescription = value;
      }
    }
    public string Title { get; set; }
    public UserType Importance
    {
      get
      {
        return importanceLevel;
      }
      set
      {
        importanceLevel = value;
      }
    }

  }




}