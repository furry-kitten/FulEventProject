﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
using ForOrganizators.Models.Перечисления;
using System.Runtime.Serialization;

namespace ForOrganizators.Models
{
    [DataContract]
    public class Sampo : BaseVM
    {
        #region Переменные
        private string entitling;
        private decimal price;
        private string rulesPath;
        private string location;
        private string currency = "RUB";
        private char shortCurrency = 'р';

        private Partner organizator;
        private List<Partner> boys = new List<Partner>();
        private List<Partner> ladiese = new List<Partner>();

        #endregion
        /**********************************************************/
        #region Конструкторы
        /// <summary>
        /// Создает новый экземпляр класса Sampo
        /// </summary>
        /// <param name="name">Название сампо</param>
        /// <param name="price">Стоимость сампо</param>
        /// <param name="organizator">Организатор сампо</param>
        public Sampo(string name, decimal price, Partner organizator)
        {
            this.entitling = name;
            this.price = price;
            this.organizator = organizator;
        }
        /// <summary>
        /// Создает новый экземпляр класса Sampo
        /// </summary>
        /// <param name="name">Название сампо</param>
        /// <param name="price">Стоимость сампо</param>
        /// <param name="organizator">Организатор сампо</param>
        /// <param name="rules">Пусть к файлу с правилами сампо</param>
        public Sampo(string name, decimal price, Partner organizator, string rules)
        {
            this.entitling = name;
            this.price = price;
            this.organizator = organizator;
            this.rulesPath = rules;
        }
        /// <summary>
        /// Создает новый экземпляр класса Sampo
        /// </summary>
        /// <param name="name">Название сампо</param>
        /// <param name="price">Стоимость сампо</param>
        /// <param name="organizator">Организатор сампо</param>
        /// <param name="rules">Пусть к файлу с правилами сампо</param>
        /// <param name="location">Адрес проведение сампо</param>
        public Sampo(string name, decimal price, Partner organizator, string rules, string location)
        {
            this.entitling = name;
            this.price = price;
            this.organizator = organizator;
            this.rulesPath = rules;
            this.location = location;
        }
        #endregion
        /**********************************************************/
        #region Поля класса
        /// <summary>
        /// Задаёт/возвращает название сампо
        /// </summary>
        [DataMember]
        public string Entitling
        {
            get => entitling;
            set 
            { 
                entitling = value;
                OnPropertyChanged();
            }
        }
        [DataMember]
        /// <summary>
        /// Задаёт/возвращает организатора
        /// </summary>
        public Partner Organizator
        {
            get => organizator;
            set
            {
                organizator = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Задаёт/возвращает стоимость сампо
        /// </summary>
        [DataMember]
        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Задаёт/возвращает путь к файлу с правилами
        /// </summary>
        [DataMember]
        public string Rules
        {
            get => rulesPath;
            set { rulesPath = value; }
        }
        /// <summary>
        /// Задаёт/возвращает адрес места проведения сампо
        /// </summary>
        [DataMember]
        public string Location
        {
            get => location;
            set { location = value; }
        }
        /// <summary>
        /// Возвращает/задаёт валюту для сампо
        /// </summary>
        [DataMember]
        public string Currency
        {
            get => currency;
            set { currency = value; }
        }
        [DataMember]
        public List<Partner> Liders
        {
            get => boys;
            set { boys = value; OnPropertyChanged(); }
        }
        [DataMember]
        public List<Partner> Followers
        {
            get => ladiese;
            set { ladiese = value; OnPropertyChanged(); }
        }

        #endregion
        /**********************************************************/
        #region Методы класса

        /// <summary>
        /// Добавляет танцора в список сампо
        /// </summary>
        /// <param name="partner">Экземпляр класса Parther</param>
        public void AddNewPartner(Partner partner)
        {
            if (partner != null && partner.Gender == Gender.Female)
                ladiese.Add(partner);
            else
                boys.Add(partner);
        }

        /// <summary>
        /// Возвращает список танцоров в зависимости от пола
        /// </summary>
        /// <param name="gender">Допустимые значения: M/F, m/f (английская раскладка список партёров/партёрш), М/Ж, м/ж (русская раскладка список партёров/партёрш)</param>
        /// <returns></returns>
        public Array GetPartnerList(Gender gender) => gender == Gender.Male ? boys.ToArray() : ladiese.ToArray();

        /// <summary>
        /// Записывает в файл строки представленные в параметре <paramref name="rules"/>.
        /// </summary>
        /// <param name="rules">Ссылка на сформированный список строковых данных для записи их в файл</param>
        /// <param name="beSureToUpdate">Поставить в true, если выполняется очередное обноление парвил в один день</param>
        public void UpdateRules(ref List<string> rules, bool beSureToUpdate = false)
        {
            if (rules == null)
                return;

            rulesPath = Assembly.GetExecutingAssembly().Location + ($@"/{entitling}rules.dat");
            DateTime LastVersion = Convert.ToDateTime("0");
            bool newRules = false;

            if (File.Exists(rulesPath))
                using (BinaryReader rulesfile = new BinaryReader(File.Open(rulesPath, FileMode.Open)))
                {
                    LastVersion = Convert.ToDateTime(rulesfile.ReadInt32() + rulesfile.ReadInt32());
                }

            if (Convert.ToDateTime(DateTime.Now.Day + '.' + DateTime.Now.Month) > LastVersion)
                newRules = true;

            if (beSureToUpdate || newRules)
            {
                List<string> stringsOfRules = new List<string>();
                stringsOfRules.Add(DateTime.Now.Day.ToString() + '.' + DateTime.Now.Month.ToString());

                foreach (string s in rules)
                    stringsOfRules.Add(s);


                using (BinaryWriter rulesFile = new BinaryWriter(File.Open(rulesPath, FileMode.OpenOrCreate)))
                {
                    foreach (string r in stringsOfRules)
                        rulesFile.Write(r);
                }
            }
        }

        /// <summary>
        /// Записывает строки правил из файла в <paramref name="rules"/>.
        /// </summary>
        /// <param name="rules">Список строковых данных для записи данных из файла (желательно пустой)</param>
        public void WriteRules(ref List<string> rules)
        {
            if (!File.Exists(rulesPath) || rules == null)
                return;

            using (BinaryReader rulesfile = new BinaryReader(File.Open(rulesPath, FileMode.Open)))
            {
                DateTime LastVersion = Convert.ToDateTime(rulesfile.ReadInt32() + rulesfile.ReadInt32());

                while (rulesfile.PeekChar() > -1)
                    rules.Add(rulesfile.ReadString());
            }
        }

        /// <summary>
        /// Записывает строки правил из файла в <paramref name="rules"/>.
        /// </summary>
        /// <param name="rules">Список строковых данных для записи данных из файла (желательно пустой)</param>
        /// <param name="LastVersion">Дата последнего обновления</param>
        public void WriteRules(ref List<string> rules, out DateTime LastVersion)
        {
            if (!File.Exists(rulesPath) || rules == null)
            {
                LastVersion = Convert.ToDateTime("0");
                return;
            }

            using (BinaryReader rulesfile = new BinaryReader(File.Open(rulesPath, FileMode.Open)))
            {
                LastVersion = Convert.ToDateTime(rulesfile.ReadString());

                while (rulesfile.PeekChar() > -1)
                    rules.Add(rulesfile.ReadString());
            }
        }



        #endregion
    }
}
