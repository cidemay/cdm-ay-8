﻿using Business.Abstract;
using Entities.concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService
    {
        public void Apply(Person person)
        {

        }
        public List<Person>GetList()
        {
            return null;
        }

        public bool checkPerson(Person person)
        {
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndPointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody())).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
