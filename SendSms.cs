
/*
 *  Copyright Red Oxygen 2005
 *
 *  C# example code to send an SMS via the Red Oxygen SMS gateway over HTTP.
 *
 *  For more details refer to the Redoxygen API
 */

using System;
using System.Data;
using System.Net;
using System.Text;


public static class RedOxygen
{
	static public int SendSms(String strAccountId,String strEmail,String strPassword,String strMSISDN,String strMessage)
	{
		WebClient wc = new WebClient();
		String sRequestURL,sRequestData;

		sRequestURL = "http://www.redoxygen.net/sms.dll?Action=SendSMS";

		sRequestData = "AccountId=" + strAccountId
			+ "&Email=" + System.Web.HttpUtility.UrlEncode(strEmail)
			+ "&Password=" + System.Web.HttpUtility.UrlEncode(strPassword)
			+ "&Recipient=" + System.Web.HttpUtility.UrlEncode(strMSISDN)
			+ "&Message=" + System.Web.HttpUtility.UrlEncode(strMessage);
	

		byte[] postData = Encoding.ASCII.GetBytes(sRequestData);
		byte[] response = wc.UploadData(sRequestURL,postData);
		
		String sResult = Encoding.ASCII.GetString(response);  // sResult contains the error text
		Console.WriteLine("-----------------");
		Console.WriteLine(sResult);
		Console.WriteLine("-----------------");

		int nResult = System.Convert.ToInt32(sResult.Substring(0,4));


		return nResult;
	}
};