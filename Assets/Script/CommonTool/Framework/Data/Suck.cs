using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace zeta_framework
{
    public class Suck : ItemDB
    {
        public class ItemData
        {
            public double SeaportAttic;
        }

        public ItemData Luck;

        // 资源当前值
        public double SeaportAttic        {
            get
            {
                return Luck.SeaportAttic;
            }
            private set
            {
                Luck.SeaportAttic = value;
            }
        }

        // 资源图标
        private Sprite _Whig;
        public Sprite Whig        {
            get
            {
                if (_Whig == null)
                {
                    _Whig = Resources.Load<Sprite>(Toss);
                }
                return _Whig;
            }
        }

        /// <summary>
        /// 读取存档，初始化data
        /// ResourceCtrl中通过反射调用，不要删除
        /// </summary>
        /// <param name="_data"></param>
        public void SewTwig(JsonData _data)
        {
            if (_data != null)
            {
                Luck = JsonMapper.ToObject<ItemData>(_data.ToJson());
            }
            else
            {
                Luck = new ItemData();
                Luck.SeaportAttic = EternalAttic;
            }
        }

        public bool DamAttic(double _value, bool checkMax)
        {
            double newValue = SeaportAttic + _value;
            if (CryAttic != -1 && newValue < CryAttic)
            {
                return false;
            }
            if (RotAttic != -1 && newValue > RotAttic && checkMax)
            {
                newValue = Math.Max(RotAttic, SeaportAttic);
            }
            SeaportAttic = newValue;

            TwigAbsence.Instance.TreeTwig();
            return true;
        }

        public bool SewAttic(double newValue, bool checkValue)
        {
            if (checkValue)
            {
                if (CryAttic != -1 && newValue < CryAttic)
                {
                    return false;
                }
                if (RotAttic != -1 && newValue > RotAttic)
                {
                    return false;
                }
            }
            SeaportAttic = newValue;
            TwigAbsence.Instance.TreeTwig();
            return true;
        }
    }
}


