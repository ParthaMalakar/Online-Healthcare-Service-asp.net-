<<<<<<< HEAD
﻿using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HospitalService
    {

        public static List<HospitalDTO> Get()
        {
           
            var data = DataAccessFactory.HospitalDataAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<HospitalDTO>>(data);
            return converted;
        }
        public static HospitalDTO Get(int id)
        {
            var data = DataAccessFactory.HospitalDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<HospitalDTO>(data);
            return converted;
        }
        public static HospitalDTO Add(HospitalDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalDTO, Hospital>();
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Hospital>(obj);
            var rs = DataAccessFactory.HospitalDataAccess().Add(converted);
            var rtrs = mapper.Map<HospitalDTO>(rs);
            return rtrs;
        }
        public static HospitalDTO Update(HospitalDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalDTO, Hospital>();
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Hospital>(obj);
            var rs = DataAccessFactory.HospitalDataAccess().Update(converted);
            var rtrs = mapper.Map<HospitalDTO>(rs);
            return rtrs;
        }
        public static bool Delete(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalDTO, Hospital>();
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            return DataAccessFactory.HospitalDataAccess().Delete(id);
        }
        public static HospitalDoctorDTOs GetwithDoctor(int id)
        {
            var data = DataAccessFactory.HospitalDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Hospital, HospitalDoctorDTOs>();
                c.CreateMap<Doctor, DoctorDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<HospitalDoctorDTOs>(data);
        }
       
    }
}
=======
﻿using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HospitalService
    {

        public static List<HospitalDTO> Get()
        {
           
            var data = DataAccessFactory.HospitalDataAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<HospitalDTO>>(data);
            return converted;
        }
        public static HospitalDTO Get(int id)
        {
            var data = DataAccessFactory.HospitalDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<HospitalDTO>(data);
            return converted;
        }
        public static HospitalDTO Add(HospitalDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalDTO, Hospital>();
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Hospital>(obj);
            var rs = DataAccessFactory.HospitalDataAccess().Add(converted);
            var rtrs = mapper.Map<HospitalDTO>(rs);
            return rtrs;
        }
        public static HospitalDTO Update(HospitalDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalDTO, Hospital>();
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Hospital>(obj);
            var rs = DataAccessFactory.HospitalDataAccess().Update(converted);
            var rtrs = mapper.Map<HospitalDTO>(rs);
            return rtrs;
        }
        public static bool Delete(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalDTO, Hospital>();
                cfg.CreateMap<Hospital, HospitalDTO>();
            });
            return DataAccessFactory.HospitalDataAccess().Delete(id);
        }

    }
}
>>>>>>> a133cd17e395f848acaf5a831722b042a4bed745
