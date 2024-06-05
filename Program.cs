using System;
using System.Collections.Generic;

public class Client
{
    public string Name { get; set; }
    public string Contact { get; set; }

    public Client(string name, string contact)
    {
        Name = name;
        Contact = contact;
    }

    public void DisplayClientInfo()
    {
        Console.WriteLine($"Client Name: {Name}\nContact: {Contact}");
    }
}

public class Campaign
{
    public string Title { get; set; }
    public double Budget { get; set; }

    public Campaign(string title, double budget)
    {
        Title = title;
        Budget = budget;
    }

    public void DisplayCampaignInfo()
    {
        Console.WriteLine($"Campaign Title: {Title}\nBudget: ${Budget}");
    }
}

public class Advertisement
{
    public string Content { get; set; }
    public string Medium { get; set; }

    public Advertisement(string content, string medium)
    {
        Content = content;
        Medium = medium;
    }

    public void DisplayAdInfo()
    {
        Console.WriteLine($"Ad Content: {Content}\nMedium: {Medium}");
    }
}

public class AgencyManagementSystem
{
    private List<Client> clients = new List<Client>();
    private List<Campaign> campaigns = new List<Campaign>();
    private List<Advertisement> advertisements = new List<Advertisement>();

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    public void AddCampaign(Campaign campaign)
    {
        campaigns.Add(campaign);
    }

    public void AddAdvertisement(Advertisement advertisement)
    {
        advertisements.Add(advertisement);
    }

    public void DisplayAllClients()
    {
        Console.WriteLine("Clients:");
        foreach (var client in clients)
        {
            client.DisplayClientInfo();
            Console.WriteLine();
        }
    }

    public void DisplayAllCampaigns()
    {
        Console.WriteLine("Campaigns:");
        foreach (var campaign in campaigns)
        {
            campaign.DisplayCampaignInfo();
            Console.WriteLine();
        }
    }

    public void DisplayAllAdvertisements()
    {
        Console.WriteLine("Advertisements:");
        foreach (var advertisement in advertisements)
        {
            advertisement.DisplayAdInfo();
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AgencyManagementSystem agency = new AgencyManagementSystem();

        Client client1 = new Client("Client A", "contactA@example.com");
        Client client2 = new Client("Client B", "contactB@example.com");

        Campaign campaign1 = new Campaign("Campaign 1", 10000);
        Campaign campaign2 = new Campaign("Campaign 2", 15000);

        Advertisement ad1 = new Advertisement("Ad Content 1", "TV");
        Advertisement ad2 = new Advertisement("Ad Content 2", "Social Media");

        agency.AddClient(client1);
        agency.AddClient(client2);

        agency.AddCampaign(campaign1);
        agency.AddCampaign(campaign2);

        agency.AddAdvertisement(ad1);
        agency.AddAdvertisement(ad2);

        Console.WriteLine("Displaying All Clients:");
        agency.DisplayAllClients();

        Console.WriteLine("\nDisplaying All Campaigns:");
        agency.DisplayAllCampaigns();

        Console.WriteLine("\nDisplaying All Advertisements:");
        agency.DisplayAllAdvertisements();
    }
}

