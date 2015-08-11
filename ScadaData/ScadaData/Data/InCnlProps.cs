﻿/*
 * Copyright 2015 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaData
 * Summary  : Input channel properties
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2005
 * Modified : 2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scada.Data
{
    /// <summary>
    /// Input channel properties
    /// <para>Свойства входного канала</para>
    /// </summary>
    public class InCnlProps : IComparable<InCnlProps>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public InCnlProps()
            : this(0, "", BaseValues.CnlTypes.TI)
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public InCnlProps(int cnlNum, string cnlName, int cnlTypeID)
        {
            CnlNum = cnlNum;
            CnlName = cnlName;
            CnlTypeID = cnlTypeID;
            ObjNum = 0;
            ObjName = "";
            KPNum = 0;
            KPName = "";
            Signal = 0;
            FormulaUsed = false;
            Formula = "";
            Averaging = false;
            ParamID = 0;
            ParamName = "";
            IconFileName = "";
            ShowNumber = true;
            DecDigits = 3;
            UnitName = "";
            UnitArr = null;
            CtrlCnlNum = 0;
            EvEnabled = false;
            EvSound = false;
            EvOnChange = false;
            EvOnUndef = false;
            LimLowCrash = double.NaN;
            LimLow = double.NaN;
            LimHigh = double.NaN;
            LimHighCrash = double.NaN;
        }


        /// <summary>
        /// Получить или установить номер входного канала
        /// </summary>
        public int CnlNum { get; set; }

        /// <summary>
        /// Получить или установить наименование входного канала
        /// </summary>
        public string CnlName { get; set; }

        /// <summary>
        /// Получить или установить идентификатор типа канала
        /// </summary>
        public int CnlTypeID { get; set; }

        /// <summary>
        /// Получить или установить номер объекта
        /// </summary>
        public int ObjNum { get; set; }

        /// <summary>
        /// Получить или установить наименование объекта
        /// </summary>
        public string ObjName { get; set; }

        /// <summary>
        /// Получить или установить номер КП
        /// </summary>
        public int KPNum { get; set; }

        /// <summary>
        /// Получить или установить наименование КП
        /// </summary>
        public string KPName { get; set; }

        /// <summary>
        /// Получить или установить сигнал (номер тега КП)
        /// </summary>
        public int Signal { get; set; }

        /// <summary>
        /// Получить или установить признак использования формулы
        /// </summary>
        public bool FormulaUsed { get; set; }

        /// <summary>
        /// Получить или установить формулу
        /// </summary>
        public string Formula { get; set; }

        /// <summary>
        /// Получить или установить признак усреднения
        /// </summary>
        public bool Averaging { get; set; }

        /// <summary>
        /// Получить или установить идентификатор параметра
        /// </summary>
        public int ParamID { get; set; }

        /// <summary>
        /// Получить или установить наименование параметра
        /// </summary>
        public string ParamName { get; set; }

        /// <summary>
        /// Получить или установить короткое имя файла значка
        /// </summary>
        public string IconFileName { get; set; }

        /// <summary>
        /// Получить или установить признак вывода значения канала как числа
        /// </summary>
        public bool ShowNumber { get; set; }

        /// <summary>
        /// Получить или установить количество знаков дробной части при выводе значения
        /// </summary>
        public int DecDigits { get; set; }

        /// <summary>
        /// Получить или установить наименование размерности
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Получить или установить размерности
        /// </summary>
        public string[] UnitArr { get; set; }

        /// <summary>
        /// Получить или установить номер канала управления
        /// </summary>
        public int CtrlCnlNum { get; set; }

        /// <summary>
        /// Получить или установить признак записи событий
        /// </summary>
        public bool EvEnabled { get; set; }

        /// <summary>
        /// Получить или установить признак воспроизведения звука события
        /// </summary>
        public bool EvSound { get; set; }

        /// <summary>
        /// Получить или установить признак записи событий по изменению
        /// </summary>
        public bool EvOnChange { get; set; }

        /// <summary>
        /// Получить или установить признак записи событий по неопределённому состоянию
        /// </summary>
        public bool EvOnUndef { get; set; }

        /// <summary>
        /// Получить или установить нижнюю аварийную границу
        /// </summary>
        public double LimLowCrash { get; set; }

        /// <summary>
        /// Получить или установить нижнюю границу
        /// </summary>
        public double LimLow { get; set; }

        /// <summary>
        /// Получить или установить верхнюю границу
        /// </summary>
        public double LimHigh { get; set; }

        /// <summary>
        /// Получить или установить верхнюю аварийную границу
        /// </summary>
        public double LimHighCrash { get; set; }


        /// <summary>
        /// Сравнить текущий объект с другим объектом того же типа
        /// </summary>
        public int CompareTo(InCnlProps other)
        {
            return CnlNum.CompareTo(other.CnlNum);
        }
    }
}
