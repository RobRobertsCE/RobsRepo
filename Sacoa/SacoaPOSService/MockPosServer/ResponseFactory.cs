using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockPosServer
{
    static class ResponseFactory
    {
        public static string GetResponse(string opName)
        {
            string responseData = String.Empty;

            switch (opName)
            {
                case "CARD DATA":
                    {
                        responseData = GetCardDataResponse();
                        break;
                    }
                case "CARD HISTORY":
                    {

                        responseData = GetCardHistoryResponse();
                        break;
                    }
                default:
                    {

                        responseData = GetErrorResponse();
                        break;
                    }
            }
            return responseData;
        }

        static string GetCardDataResponse()
        {
            return "OK, CARD DATA, OK";
        }
        static string GetCardHistoryResponse()
        {
            return "OK, CARD HISTORY, OK";
        }
        static string GetErrorResponse()
        {
            return "ERROR, ERROR, ERROR";
        } 
    }
}
