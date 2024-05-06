using ghabzinow.Services.IServices;
using ghabzinow.ViewModel;
using ghabzinow.ViewModel.UtitlityBills;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Principal;
using System.Text;

namespace ghabzinow.Services
{
    public class UtilityBillsService : IUtilityBillsService
    {
        readonly string token = "7ADB92ED439D4CF2B7027068452BE413";

       
        public async Task <FinalyResponse<UtilityBill>> ElectricityBillInquiry(ElectricityBillInquiryDto requestBody)
        {
            try
            {
          
            string url = "https://core.inquiry.ayantech.ir/webservices/core.svc/ElectricityBillInquiry";


            HttpClient client = new HttpClient();

            var request = new FinalRequsetDto<ElectricityParametersDto>
            {
                Identity = new IdentityDto
                {
                    Token = token,
                },
                Parameters = new ElectricityParametersDto
                {
                    ElectricityBillID = requestBody.ElectricityBillID,

                },

            };
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            FinalyResponse<UtilityBill> finalRequsetDto=null;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                finalRequsetDto = JsonConvert.DeserializeObject<FinalyResponse<UtilityBill>>(responseContent);
            }
           
            return finalRequsetDto;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task<FinalyResponse<GasBill>> GasBillInquiry(GasBillInquiryDto bill)
        {
            string url = "https://core.inquiry.ayantech.ir/webservices/core.svc/GasBillInquiry";


            HttpClient client = new HttpClient();

            var request = new FinalRequsetDto<GasParametersDto>
            {
                Identity = new IdentityDto
                {
                    Token = token,
                },
                Parameters = new GasParametersDto
                {
                    GasBillID = bill.GasBillID,
                    ParticipateCode =bill.ParticipateCode,

                },

            };
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            FinalyResponse<GasBill> finalRequsetDto = null;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                finalRequsetDto = JsonConvert.DeserializeObject<FinalyResponse<GasBill>>(responseContent);
            }

            return finalRequsetDto;
        } 
        public async Task<FinalyResponse<FixedLineBill>> FixedLine(FixedLineNumberInquiryDto bill)
        {
            try
            {

                string url = "https://core.inquiry.ayantech.ir/webservices/core.svc/FixedLineBillInquiry";


                HttpClient client = new HttpClient();

                var request = new FinalRequsetDto<FixedLineNumberParametersDto>
                {
                    Identity = new IdentityDto
                    {
                        Token = token,
                    },
                    Parameters = new FixedLineNumberParametersDto
                    {
                        FixedLineNumber = bill.FixedLineNumber
                        ,
                    },

                };
                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);
                FinalyResponse<FixedLineBill> finalRequsetDto = null;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    finalRequsetDto = JsonConvert.DeserializeObject<FinalyResponse<FixedLineBill>>(responseContent);
                }

                return finalRequsetDto;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task<FinalyResponse<MobileBill>> TeleKishMobile(MobileInquiryDto bill)
        {
            string url = "https://core.inquiry.ayantech.ir/webservices/core.svc/GasBillInquiry";


            HttpClient client = new HttpClient();

            var request = new FinalRequsetDto<MobileParametersDto>
            {
                Identity = new IdentityDto
                {
                    Token = token,
                },
                Parameters = new MobileParametersDto
                {
                    MobileNumber = bill.MobileNumber

                },

            };
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            FinalyResponse<MobileBill> finalRequsetDto = null;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                finalRequsetDto = JsonConvert.DeserializeObject<FinalyResponse<MobileBill>>(responseContent);
            }

            return finalRequsetDto;
        }

        public async Task<FinalyResponse<WaterBill>> WaterBillInquiry(WaterBillInquiryDto bill)
        {
            string url = "https://core.inquiry.ayantech.ir/webservices/core.svc/WaterBillInquiry";


            HttpClient client = new HttpClient();

            var request = new FinalRequsetDto<WaterParametersDto>
            {
                Identity = new IdentityDto
                {
                    Token = token,
                },
                Parameters = new WaterParametersDto
                {
                WaterBillID= bill.WaterBillID,

                },
            };
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            FinalyResponse<WaterBill> finalRequsetDto = new FinalyResponse<WaterBill>();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                finalRequsetDto = JsonConvert.DeserializeObject<FinalyResponse<WaterBill>>(responseContent);
            }
            return finalRequsetDto;
        }

        public async Task<FinalyResponse<MobileBill>> MCIMobileBillInquiry(MobileInquiryDto bill)
        {
            string url = "https://core.inquiry.ayantech.ir/webservices/core.svc/MCIMobileBillInquiry";


            HttpClient client = new HttpClient();

            var request = new FinalRequsetDto<MobileParametersDto>
            {
                Identity = new IdentityDto
                {
                    Token = token,
                },
                Parameters = new MobileParametersDto
                {
                    MobileNumber = bill.MobileNumber

                },

            };
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            FinalyResponse<MobileBill> finalRequsetDto = null;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                finalRequsetDto = JsonConvert.DeserializeObject<FinalyResponse<MobileBill>>(responseContent);
            }

            return finalRequsetDto;
        }
    }
}
