
using System.Xml;
namespace CreateXMLs
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode reportContent = doc.CreateElement("REMITTable1");
            doc.AppendChild(reportContent);

            //reportingEntiryID
            XmlNode entityID = doc.CreateElement("reportingEntiryID");
            reportContent.AppendChild(entityID);

            XmlNode aceNode = doc.CreateElement("ace");
            aceNode.AppendChild(doc.CreateTextNode("B0000116N.NO"));
            entityID.AppendChild(aceNode);

            //contractList
            XmlNode contractList = doc.CreateElement("contractList");
            reportContent.AppendChild(contractList);

            XmlNode contract = doc.CreateElement("contract");
            contractList.AppendChild(contract);

            ////description of the contract
            XmlNode contractId = doc.CreateElement("contractId");
            contractId.AppendChild(doc.CreateTextNode("N2EX_20150611_1200_UK"));
            contract.AppendChild(contractId);

            XmlNode contractName = doc.CreateElement("contractName");
            contractName.AppendChild(doc.CreateTextNode("N2EX_Day_Ahead_UK"));
            contract.AppendChild(contractName);

            XmlNode contractType = doc.CreateElement("contractType");
            contractType.AppendChild(doc.CreateTextNode("AU"));
            contract.AppendChild(contractType);

            XmlNode energyCommodity = doc.CreateElement("energyCommodity");
            energyCommodity.AppendChild(doc.CreateTextNode("EL"));
            contract.AppendChild(energyCommodity);

            XmlNode settlementMethod = doc.CreateElement("settlementMethod");
            settlementMethod.AppendChild(doc.CreateTextNode("P"));
            contract.AppendChild(settlementMethod);

            XmlNode organisedMarketPlaceIdentifier = doc.CreateElement("organisedMarketPlaceIdentifier");
            contract.AppendChild(organisedMarketPlaceIdentifier);
            XmlNode mic = doc.CreateElement("mic");
            mic.AppendChild(doc.CreateTextNode("N2EX"));
            organisedMarketPlaceIdentifier.AppendChild(mic);

            XmlNode contractTradingHours = doc.CreateElement("contractTradingHours");
            contract.AppendChild(contractTradingHours);
            XmlNode startTime = doc.CreateElement("startTime");
            startTime.AppendChild(doc.CreateTextNode("00:00:00"));
            contractTradingHours.AppendChild(startTime);
            XmlNode endTime = doc.CreateElement("ensTime");
            endTime.AppendChild(doc.CreateTextNode("00:00:00"));
            contract.AppendChild(endTime);

            XmlNode lastTradingDateTime = doc.CreateElement("lastTradingDateTime");
            lastTradingDateTime.AppendChild(doc.CreateTextNode("2015-06-11T12:00:00Z"));
            contract.AppendChild(lastTradingDateTime);

            XmlNode deliveryPointOrZone = doc.CreateElement("deliveryPointOrZone");
            deliveryPointOrZone.AppendChild(doc.CreateTextNode("10YGB----------A"));
            contract.AppendChild(deliveryPointOrZone);

            XmlNode deliveryStartDate = doc.CreateElement("deliveryStartDate");
            deliveryStartDate.AppendChild(doc.CreateTextNode("2015-06-12"));
            contract.AppendChild(deliveryStartDate);

            XmlNode deliveryEndDate = doc.CreateElement("deliveryEndDate");
            deliveryEndDate.AppendChild(doc.CreateTextNode("22015-06-12"));
            contract.AppendChild(deliveryEndDate);

            XmlNode duration = doc.CreateElement("duration");
            duration.AppendChild(doc.CreateTextNode("H"));
            contract.AppendChild(duration);

            XmlNode loadType = doc.CreateElement("loadType");
            loadType.AppendChild(doc.CreateTextNode("BH"));
            contract.AppendChild(loadType);

            XmlNode deliveryProfile = doc.CreateElement("deliveryProfile");
            contract.AppendChild(deliveryProfile);
            XmlNode loadDeleiveryStartTime = doc.CreateElement("loadDelieveryStartTime");
            loadDeleiveryStartTime.AppendChild(doc.CreateTextNode("00:00:00"));
            deliveryProfile.AppendChild(loadDeleiveryStartTime);

            XmlNode loadDeliveryEndTime = doc.CreateElement("loadDeliveryEndTime");
            loadDeliveryEndTime.AppendChild(doc.CreateTextNode("00:00:00"));
            deliveryProfile.AppendChild(loadDeliveryEndTime);

            //OrderList


            doc.Save(@"C:\Users\Qian.Zhou\Documents\Visual Studio 2013\Projects\c#\CreateXMLs\test.xml");

            /*XmlNode productsNode = doc.CreateElement("products");
            doc.AppendChild(productsNode);

            XmlNode productNode = doc.CreateElement("product");
            XmlAttribute productAttribute = doc.CreateAttribute("id");
            productAttribute.Value = "01";
            productNode.Attributes.Append(productAttribute);
            productsNode.AppendChild(productNode);

            XmlNode nameNode = doc.CreateElement("Name");
            nameNode.AppendChild(doc.CreateTextNode("Java"));
            productNode.AppendChild(nameNode);
            XmlNode priceNode = doc.CreateElement("Price");
            priceNode.AppendChild(doc.CreateTextNode("Free"));
            productNode.AppendChild(priceNode);

            // Create and add another product node.
            productNode = doc.CreateElement("product");
            productAttribute = doc.CreateAttribute("id");
            productAttribute.Value = "02";
            productNode.Attributes.Append(productAttribute);
            productsNode.AppendChild(productNode);
            nameNode = doc.CreateElement("Name");
            nameNode.AppendChild(doc.CreateTextNode("C#"));
            productNode.AppendChild(nameNode);
            priceNode = doc.CreateElement("Price");
            priceNode.AppendChild(doc.CreateTextNode("Free"));
            productNode.AppendChild(priceNode);
            doc.Save(@"C:\Users\Qian.Zhou\Documents\Visual Studio 2013\Projects\c#\CreateXMLs\testproduct.xml");
            */
        }
    }
}
