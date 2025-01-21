using FreshService.Commons.Models;
using FreshService.Commons.Requests;
using FreshService.Commons.Responses;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;

namespace FreshService.Commons
{
    public class FreshServiceManager
    {
        private string _Url { get; }
        private string _ApiKeyEncoded { get; }

        public FreshServiceManager(string url, string apiKeyEncoded)
        {
            _Url = url;
            _ApiKeyEncoded = apiKeyEncoded;
        }

        public bool TryCreateTicket(FreshServiceCreateTicketRequest ticketRequest)
        {
            var options = new RestClientOptions(_Url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = "tickets";


            var request = new RestRequest(resource, Method.Post);
            request.AddBody(ticketRequest, ContentType.Json);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");

            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                FreshServiceCreateTicketResponse getAllTicketsResponse = JsonConvert.DeserializeObject<FreshServiceCreateTicketResponse>(response.Content);
                if (getAllTicketsResponse != null)
                    return true;
                else
                {
                    throw new Exception($"Invalid \"TryCreateTicket\" format: {response.Content}.");
                }
            }
            else
            {
                throw new Exception($"Invalid \"TryCreateTicket\" format: {response.Content}.");
            }
        }

        public List<FreshServiceTicket> GetAllTickets(IDictionary<string, string> parameters = null)
        {
            var options = new RestClientOptions(_Url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = "tickets";
            if (parameters != null)
            {
                resource += "?";
                foreach (string key in parameters.Keys)
                {
                    resource += $"{key}={parameters[key]}";
                    if (!key.Equals(parameters.Keys.Last()))
                        resource += "&";
                }
            }
            var request = new RestRequest(resource, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}"); //STNPclN3T240WFRMYnRtb0lWa2Y6WA==
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                GetAllTicketsResponse getAllTicketsResponse = JsonConvert.DeserializeObject<GetAllTicketsResponse>(response.Content);
                if (getAllTicketsResponse != null)
                    return getAllTicketsResponse.tickets;
                else
                {
                    throw new Exception($"Invalid \"GetAllTicketsReponse\" format: {response.Content}.");
                }
            }
            else
            {
                throw new Exception($"Invalid \"GetAllTickets\" format: {response.Content}.");
            }
        }
        public List<FreshServiceTicket> GetTickets(string filter)
        {
            var options = new RestClientOptions(_Url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"tickets/filter?query=\"{filter}\"";
            var request = new RestRequest(resource, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}"); //STNPclN3T240WFRMYnRtb0lWa2Y6WA==
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                GetAllTicketsResponse getAllTicketsResponse = JsonConvert.DeserializeObject<GetAllTicketsResponse>(response.Content);
                if (getAllTicketsResponse != null)
                    return getAllTicketsResponse.tickets;
                else
                {
                    throw new Exception($"Invalid \"GetAllTicketsReponse\" format: {response.Content}.");
                }
            }
            else
            {
                throw new Exception($"Invalid \"GetAllTickets\" format: {response.Content}.");
            }
        }

        public bool TryPostEmployeeOnboarding(FreshServiceOnboardingRequest onboardingRequest)
        {
            var options = new RestClientOptions(_Url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"onboarding_requests";
            var request = new RestRequest(resource, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            request.AddBody(onboardingRequest);
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return true;
            }
            else
            {
                throw new Exception($"Invalid \"PostEmployeeOnboarding\" format: {response.Content}.");
            }
        }

        public GetAllLocationsResponse GetAllLocations()
        {
            var options = new RestClientOptions(_Url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = "locations";
            var request = new RestRequest(resource, Method.Get);
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                GetAllLocationsResponse getAllLocationsResponse = JsonConvert.DeserializeObject<GetAllLocationsResponse>(response.Content);
                if (getAllLocationsResponse != null)
                    return getAllLocationsResponse;
                else
                {
                    throw new Exception($"Invalid \"GetAllLocationsResponse\" format: {response.Content}.");
                }
            }
            else
            {
                throw new Exception($"Invalid \"GetAllLocations\" format: {response.Content}.");
            }
        }

        public FreshServiceLocation GetLocation(string name)
        {
        https://firstmidbank.freshservice.com/api/v2/
            var options = new RestClientOptions(_Url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"locations?query=\"name:'{name}'\"";
            var request = new RestRequest(resource, Method.Get);
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                GetAllLocationsResponse getAllLocationsResponse = JsonConvert.DeserializeObject<GetAllLocationsResponse>(response.Content);
                if (getAllLocationsResponse != null)
                    return getAllLocationsResponse.locations.First();
                else
                {
                    throw new Exception($"Invalid \"GetAllLocationsResponse\" format: {response.Content}.");
                }
            }
            else
            {
                throw new Exception($"Invalid \"GetLocation\" format: {response.Content}.");
            }
        }

        public bool TryCloseTicket(int id, string notes)
        {
            var options = new RestClientOptions($"{_Url}")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"tickets/{id}";
            var request = new RestRequest(resource, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            request.AddJsonBody("{ \"status\": 5, \"subject\": \"" + notes + "\"}");
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                throw new Exception($"Invalid \"TryCloseTicket\" format: {response.Content}.");
            }
        }

        public bool TryAddSubjectNotes(int id, string notes)
        {
            var options = new RestClientOptions($"{_Url}")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"tickets/{id}";
            var request = new RestRequest(resource, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            request.AddJsonBody("{ \"subject\": \"" + notes + "\"}");
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                throw new Exception($"Invalid \"TryAddResolutionNotes\" format: {response.Content}.");
            }
        }

        public bool TryUpdateTicketStatus(int id, string status)
        {
            var options = new RestClientOptions($"{_Url}")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"tickets/{id}";
            var request = new RestRequest(resource, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            request.AddJsonBody("{ \"status\": " + status + "}");
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                throw new Exception($"Invalid \"TryUpdateTicketStatus\" format: {response.Content}.");
            }
        }

        public bool TryUpdateTicketGroupID(int id, string groupID)
        {
            var options = new RestClientOptions($"{_Url}")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string resource = $"tickets/{id}";
            var request = new RestRequest(resource, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {_ApiKeyEncoded}");
            request.AddJsonBody("{ \"group_id\": " + groupID + "}");
            RestResponse response = client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                throw new Exception($"Invalid \"TryUpdateTicketGroupID\" format: {response.Content}.");
            }
        }

        //group_id
    }
}
