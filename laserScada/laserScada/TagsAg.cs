using System;
using log4netSample.Logging;
using System.Collections.Generic;
 namespace laserScada {

partial class Tags {
//-----------------------------------------------------------------------------
//tags/am.xml
//-----------------------------------------------------------------------------
// ��_���������1 (������������1/�����������),   Real, %MD604   reg = M  width = UInt32
    public float get_am_termopara1 ()
    { return (float) m_mem.getMFloat(604); }

    public void set_am_termopara1 (float val)
    { m_mem.setMFloat(604, (float) val); 
      Log.Write(LogLevel.Info, "set am_termopara1 to " + val.ToString());}

    public bool sets_am_termopara1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_termopara1 (val);
    return true;}

    public string gets_am_termopara1 () { 
    return get_am_termopara1().ToString();}

    public string debug_name_am_termopara1 () { 
    return "��_���������1";}

// ��_������������� (������������������/������������),   Real, %MD616   reg = M  width = UInt32
    public float get_am_dif_datch_rash ()
    { return (float) m_mem.getMFloat(616); }

    public void set_am_dif_datch_rash (float val)
    { m_mem.setMFloat(616, (float) val); 
      Log.Write(LogLevel.Info, "set am_dif_datch_rash to " + val.ToString());}

    public bool sets_am_dif_datch_rash ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dif_datch_rash (val);
    return true;}

    public string gets_am_dif_datch_rash () { 
    return get_am_dif_datch_rash().ToString();}

    public string debug_name_am_dif_datch_rash () { 
    return "��_�������������";}

// ��_������������� (��������������������/������������),   Real, %MD620   reg = M  width = UInt32
    public float get_am_dawl_lew_fil_tr ()
    { return (float) m_mem.getMFloat(620); }

    public void set_am_dawl_lew_fil_tr (float val)
    { m_mem.setMFloat(620, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_lew_fil_tr to " + val.ToString());}

    public bool sets_am_dawl_lew_fil_tr ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_lew_fil_tr (val);
    return true;}

    public string gets_am_dawl_lew_fil_tr () { 
    return get_am_dawl_lew_fil_tr().ToString();}

    public string debug_name_am_dawl_lew_fil_tr () { 
    return "��_�������������";}

// ��_�������������� (���������������������/������������),   Real, %MD624   reg = M  width = UInt32
    public float get_am_dawl_praw_fil_tr ()
    { return (float) m_mem.getMFloat(624); }

    public void set_am_dawl_praw_fil_tr (float val)
    { m_mem.setMFloat(624, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_praw_fil_tr to " + val.ToString());}

    public bool sets_am_dawl_praw_fil_tr ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_praw_fil_tr (val);
    return true;}

    public string gets_am_dawl_praw_fil_tr () { 
    return get_am_dawl_praw_fil_tr().ToString();}

    public string debug_name_am_dawl_praw_fil_tr () { 
    return "��_��������������";}

// ��_������� (��������/����),   Real, %MD642   reg = M  width = UInt32
    public float get_am_linejka ()
    { return (float) m_mem.getMFloat(642); }

    public void set_am_linejka (float val)
    { m_mem.setMFloat(642, (float) val); 
      Log.Write(LogLevel.Info, "set am_linejka to " + val.ToString());}

    public bool sets_am_linejka ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_linejka (val);
    return true;}

    public string gets_am_linejka () { 
    return get_am_linejka().ToString();}

    public string debug_name_am_linejka () { 
    return "��_�������";}

// ��_���1�������� (����1����������������/�����������),   Real, %MD650   reg = M  width = UInt32
    public float get_am_tjen1_tek_moschn ()
    { return (float) m_mem.getMFloat(650); }

    public void set_am_tjen1_tek_moschn (float val)
    { m_mem.setMFloat(650, (float) val); 
      Log.Write(LogLevel.Info, "set am_tjen1_tek_moschn to " + val.ToString());}

    public bool sets_am_tjen1_tek_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_tjen1_tek_moschn (val);
    return true;}

    public string gets_am_tjen1_tek_moschn () { 
    return get_am_tjen1_tek_moschn().ToString();}

    public string debug_name_am_tjen1_tek_moschn () { 
    return "��_���1��������";}

// ��_������������ (������������������������/�������),   Real, %MD734   reg = M  width = UInt32
    public float get_am_kar_lew_tek_poz ()
    { return (float) m_mem.getMFloat(734); }

    public void set_am_kar_lew_tek_poz (float val)
    { m_mem.setMFloat(734, (float) val); 
      Log.Write(LogLevel.Info, "set am_kar_lew_tek_poz to " + val.ToString());}

    public bool sets_am_kar_lew_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_kar_lew_tek_poz (val);
    return true;}

    public string gets_am_kar_lew_tek_poz () { 
    return get_am_kar_lew_tek_poz().ToString();}

    public string debug_name_am_kar_lew_tek_poz () { 
    return "��_������������";}

// ��_���������� (�����������/����),   Real, %MD738   reg = M  width = UInt32
    public float get_am_stol_tek_poz ()
    { return (float) m_mem.getMFloat(738); }

    public void set_am_stol_tek_poz (float val)
    { m_mem.setMFloat(738, (float) val); 
      Log.Write(LogLevel.Info, "set am_stol_tek_poz to " + val.ToString());}

    public bool sets_am_stol_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_stol_tek_poz (val);
    return true;}

    public string gets_am_stol_tek_poz () { 
    return get_am_stol_tek_poz().ToString();}

    public string debug_name_am_stol_tek_poz () { 
    return "��_����������";}

// ��_���1_����1 (������������1/�������),   Real, %MD654   reg = M  width = UInt32
    public float get_am_laz1_temp1 ()
    { return (float) m_mem.getMFloat(654); }

    public void set_am_laz1_temp1 (float val)
    { m_mem.setMFloat(654, (float) val); 
      Log.Write(LogLevel.Info, "set am_laz1_temp1 to " + val.ToString());}

    public bool sets_am_laz1_temp1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_laz1_temp1 (val);
    return true;}

    public string gets_am_laz1_temp1 () { 
    return get_am_laz1_temp1().ToString();}

    public string debug_name_am_laz1_temp1 () { 
    return "��_���1_����1";}

// ��_���1_����2 (������������2/�������),   Real, %MD658   reg = M  width = UInt32
    public float get_am_laz1_temp2 ()
    { return (float) m_mem.getMFloat(658); }

    public void set_am_laz1_temp2 (float val)
    { m_mem.setMFloat(658, (float) val); 
      Log.Write(LogLevel.Info, "set am_laz1_temp2 to " + val.ToString());}

    public bool sets_am_laz1_temp2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_laz1_temp2 (val);
    return true;}

    public string gets_am_laz1_temp2 () { 
    return get_am_laz1_temp2().ToString();}

    public string debug_name_am_laz1_temp2 () { 
    return "��_���1_����2";}

// ��_���1_����3 (������������3/�������),   Real, %MD662   reg = M  width = UInt32
    public float get_am_laz1_temp3 ()
    { return (float) m_mem.getMFloat(662); }

    public void set_am_laz1_temp3 (float val)
    { m_mem.setMFloat(662, (float) val); 
      Log.Write(LogLevel.Info, "set am_laz1_temp3 to " + val.ToString());}

    public bool sets_am_laz1_temp3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_laz1_temp3 (val);
    return true;}

    public string gets_am_laz1_temp3 () { 
    return get_am_laz1_temp3().ToString();}

    public string debug_name_am_laz1_temp3 () { 
    return "��_���1_����3";}

// ��_���2_����1 (������������4/�������),   Real, %MD666   reg = M  width = UInt32
    public float get_am_laz2_temp1 ()
    { return (float) m_mem.getMFloat(666); }

    public void set_am_laz2_temp1 (float val)
    { m_mem.setMFloat(666, (float) val); 
      Log.Write(LogLevel.Info, "set am_laz2_temp1 to " + val.ToString());}

    public bool sets_am_laz2_temp1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_laz2_temp1 (val);
    return true;}

    public string gets_am_laz2_temp1 () { 
    return get_am_laz2_temp1().ToString();}

    public string debug_name_am_laz2_temp1 () { 
    return "��_���2_����1";}

// ��_���2_����2 (������������5/�������),   Real, %MD670   reg = M  width = UInt32
    public float get_am_laz2_temp2 ()
    { return (float) m_mem.getMFloat(670); }

    public void set_am_laz2_temp2 (float val)
    { m_mem.setMFloat(670, (float) val); 
      Log.Write(LogLevel.Info, "set am_laz2_temp2 to " + val.ToString());}

    public bool sets_am_laz2_temp2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_laz2_temp2 (val);
    return true;}

    public string gets_am_laz2_temp2 () { 
    return get_am_laz2_temp2().ToString();}

    public string debug_name_am_laz2_temp2 () { 
    return "��_���2_����2";}

// ��_���2_����3 (������������6/�������),   Real, %MD674   reg = M  width = UInt32
    public float get_am_laz2_temp3 ()
    { return (float) m_mem.getMFloat(674); }

    public void set_am_laz2_temp3 (float val)
    { m_mem.setMFloat(674, (float) val); 
      Log.Write(LogLevel.Info, "set am_laz2_temp3 to " + val.ToString());}

    public bool sets_am_laz2_temp3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_laz2_temp3 (val);
    return true;}

    public string gets_am_laz2_temp3 () { 
    return get_am_laz2_temp3().ToString();}

    public string debug_name_am_laz2_temp3 () { 
    return "��_���2_����3";}

// ��_���������1 (���������1/������������),   Real, %MD628   reg = M  width = UInt32
    public float get_am_datch_kisl1 ()
    { return (float) m_mem.getMFloat(628); }

    public void set_am_datch_kisl1 (float val)
    { m_mem.setMFloat(628, (float) val); 
      Log.Write(LogLevel.Info, "set am_datch_kisl1 to " + val.ToString());}

    public bool sets_am_datch_kisl1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_datch_kisl1 (val);
    return true;}

    public string gets_am_datch_kisl1 () { 
    return get_am_datch_kisl1().ToString();}

    public string debug_name_am_datch_kisl1 () { 
    return "��_���������1";}

// ��_���������2 (���������2/������������),   Real, %MD632   reg = M  width = UInt32
    public float get_am_datch_kisl2 ()
    { return (float) m_mem.getMFloat(632); }

    public void set_am_datch_kisl2 (float val)
    { m_mem.setMFloat(632, (float) val); 
      Log.Write(LogLevel.Info, "set am_datch_kisl2 to " + val.ToString());}

    public bool sets_am_datch_kisl2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_datch_kisl2 (val);
    return true;}

    public string gets_am_datch_kisl2 () { 
    return get_am_datch_kisl2().ToString();}

    public string debug_name_am_datch_kisl2 () { 
    return "��_���������2";}

// ��_������������� (�������������������������/�������),   Real, %MD742   reg = M  width = UInt32
    public float get_am_kar_praw_tek_poz ()
    { return (float) m_mem.getMFloat(742); }

    public void set_am_kar_praw_tek_poz (float val)
    { m_mem.setMFloat(742, (float) val); 
      Log.Write(LogLevel.Info, "set am_kar_praw_tek_poz to " + val.ToString());}

    public bool sets_am_kar_praw_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_kar_praw_tek_poz (val);
    return true;}

    public string gets_am_kar_praw_tek_poz () { 
    return get_am_kar_praw_tek_poz().ToString();}

    public string debug_name_am_kar_praw_tek_poz () { 
    return "��_�������������";}

// ��_����������� (����������������/������������),   Real, %MD636   reg = M  width = UInt32
    public float get_am_dawl_w_kamere ()
    { return (float) m_mem.getMFloat(636); }

    public void set_am_dawl_w_kamere (float val)
    { m_mem.setMFloat(636, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_w_kamere to " + val.ToString());}

    public bool sets_am_dawl_w_kamere ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_w_kamere (val);
    return true;}

    public string gets_am_dawl_w_kamere () { 
    return get_am_dawl_w_kamere().ToString();}

    public string debug_name_am_dawl_w_kamere () { 
    return "��_�����������";}

// ��_�������1 (���������������1/������),   Real, %MD646   reg = M  width = UInt32
    public float get_am_ohl_skan1 ()
    { return (float) m_mem.getMFloat(646); }

    public void set_am_ohl_skan1 (float val)
    { m_mem.setMFloat(646, (float) val); 
      Log.Write(LogLevel.Info, "set am_ohl_skan1 to " + val.ToString());}

    public bool sets_am_ohl_skan1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_ohl_skan1 (val);
    return true;}

    public string gets_am_ohl_skan1 () { 
    return get_am_ohl_skan1().ToString();}

    public string debug_name_am_ohl_skan1 () { 
    return "��_�������1";}

// ��_�������2 (���������������2/������),   Real, %MD678   reg = M  width = UInt32
    public float get_am_ohl_skan2 ()
    { return (float) m_mem.getMFloat(678); }

    public void set_am_ohl_skan2 (float val)
    { m_mem.setMFloat(678, (float) val); 
      Log.Write(LogLevel.Info, "set am_ohl_skan2 to " + val.ToString());}

    public bool sets_am_ohl_skan2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_ohl_skan2 (val);
    return true;}

    public string gets_am_ohl_skan2 () { 
    return get_am_ohl_skan2().ToString();}

    public string debug_name_am_ohl_skan2 () { 
    return "��_�������2";}

// ����� (�����/UDEFINED),   Int, %MW684   reg = M  width = UInt16
    public Int16 get_nomer ()
    { return (Int16) m_mem.getMUInt16(684); }

    public void set_nomer (Int16 val)
    { m_mem.setMUInt16(684, (UInt16) val); 
      Log.Write(LogLevel.Info, "set nomer to " + val.ToString());}

    public bool sets_nomer ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_nomer (val);
    return true;}

    public string gets_nomer () { 
    return get_nomer().ToString();}

    public string debug_name_nomer () { 
    return "�����";}

// ��_���������������� (���������������������/������������),   Real, %MD686   reg = M  width = UInt32
    public float get_am_dawl_w_kamere_dubl_r ()
    { return (float) m_mem.getMFloat(686); }

    public void set_am_dawl_w_kamere_dubl_r (float val)
    { m_mem.setMFloat(686, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_w_kamere_dubl_r to " + val.ToString());}

    public bool sets_am_dawl_w_kamere_dubl_r ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_w_kamere_dubl_r (val);
    return true;}

    public string gets_am_dawl_w_kamere_dubl_r () { 
    return get_am_dawl_w_kamere_dubl_r().ToString();}

    public string debug_name_am_dawl_w_kamere_dubl_r () { 
    return "��_����������������";}

// ��_����� (����������������/������������),   Real, %MD690   reg = M  width = UInt32
    public float get_am_oxik ()
    { return (float) m_mem.getMFloat(690); }

    public void set_am_oxik (float val)
    { m_mem.setMFloat(690, (float) val); 
      Log.Write(LogLevel.Info, "set am_oxik to " + val.ToString());}

    public bool sets_am_oxik ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_oxik (val);
    return true;}

    public string gets_am_oxik () { 
    return get_am_oxik().ToString();}

    public string debug_name_am_oxik () { 
    return "��_�����";}

public enum local_am{
am_termopara1,
am_dif_datch_rash,
am_dawl_lew_fil_tr,
am_dawl_praw_fil_tr,
am_linejka,
am_tjen1_tek_moschn,
am_kar_lew_tek_poz,
am_stol_tek_poz,
am_laz1_temp1,
am_laz1_temp2,
am_laz1_temp3,
am_laz2_temp1,
am_laz2_temp2,
am_laz2_temp3,
am_datch_kisl1,
am_datch_kisl2,
am_kar_praw_tek_poz,
am_dawl_w_kamere,
am_ohl_skan1,
am_ohl_skan2,
nomer,
am_dawl_w_kamere_dubl_r,
am_oxik,
};

public gTags[] group_am = {
gTags.am_termopara1,
gTags.am_dif_datch_rash,
gTags.am_dawl_lew_fil_tr,
gTags.am_dawl_praw_fil_tr,
gTags.am_linejka,
gTags.am_tjen1_tek_moschn,
gTags.am_kar_lew_tek_poz,
gTags.am_stol_tek_poz,
gTags.am_laz1_temp1,
gTags.am_laz1_temp2,
gTags.am_laz1_temp3,
gTags.am_laz2_temp1,
gTags.am_laz2_temp2,
gTags.am_laz2_temp3,
gTags.am_datch_kisl1,
gTags.am_datch_kisl2,
gTags.am_kar_praw_tek_poz,
gTags.am_dawl_w_kamere,
gTags.am_ohl_skan1,
gTags.am_ohl_skan2,
gTags.nomer,
gTags.am_dawl_w_kamere_dubl_r,
gTags.am_oxik,
};

//-----------------------------------------------------------------------------
//tags/dm.xml
//-----------------------------------------------------------------------------
// ��_����_���_������ (����������������/����),   Bool, %M521.1   reg = M  width = Bit
    public bool get_dm_stol_abs_domgot ()
    { return (bool) m_mem.getMBit(521, 1); }

    public void set_dm_stol_abs_domgot (bool val)
    { m_mem.setMBit(521, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_stol_abs_domgot to " + val.ToString());}

    public bool sets_dm_stol_abs_domgot ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_stol_abs_domgot (val);
    return true;}

    public string gets_dm_stol_abs_domgot () { 
    return get_dm_stol_abs_domgot().ToString();}

    public string debug_name_dm_stol_abs_domgot () { 
    return "��_����_���_������";}

// ��_���1_����1 (������1�-�������1/�������),   Bool, %M532.5   reg = M  width = Bit
    public bool get_dm_laz1_prot1 ()
    { return (bool) m_mem.getMBit(532, 5); }

    public void set_dm_laz1_prot1 (bool val)
    { m_mem.setMBit(532, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_laz1_prot1 to " + val.ToString());}

    public bool sets_dm_laz1_prot1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_laz1_prot1 (val);
    return true;}

    public string gets_dm_laz1_prot1 () { 
    return get_dm_laz1_prot1().ToString();}

    public string debug_name_dm_laz1_prot1 () { 
    return "��_���1_����1";}

// ��_���1_����2 (������1�-�������2/�������),   Bool, %M532.6   reg = M  width = Bit
    public bool get_dm_laz1_prot2 ()
    { return (bool) m_mem.getMBit(532, 6); }

    public void set_dm_laz1_prot2 (bool val)
    { m_mem.setMBit(532, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_laz1_prot2 to " + val.ToString());}

    public bool sets_dm_laz1_prot2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_laz1_prot2 (val);
    return true;}

    public string gets_dm_laz1_prot2 () { 
    return get_dm_laz1_prot2().ToString();}

    public string debug_name_dm_laz1_prot2 () { 
    return "��_���1_����2";}

// ��_���1_����3 (������1�-�������2/�������),   Bool, %M534.4   reg = M  width = Bit
    public bool get_dm_laz1_prot3 ()
    { return (bool) m_mem.getMBit(534, 4); }

    public void set_dm_laz1_prot3 (bool val)
    { m_mem.setMBit(534, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_laz1_prot3 to " + val.ToString());}

    public bool sets_dm_laz1_prot3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_laz1_prot3 (val);
    return true;}

    public string gets_dm_laz1_prot3 () { 
    return get_dm_laz1_prot3().ToString();}

    public string debug_name_dm_laz1_prot3 () { 
    return "��_���1_����3";}

// ��_���2_����1 (������2�-�������1/�������),   Bool, %M534.5   reg = M  width = Bit
    public bool get_dm_laz2_prot1 ()
    { return (bool) m_mem.getMBit(534, 5); }

    public void set_dm_laz2_prot1 (bool val)
    { m_mem.setMBit(534, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_laz2_prot1 to " + val.ToString());}

    public bool sets_dm_laz2_prot1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_laz2_prot1 (val);
    return true;}

    public string gets_dm_laz2_prot1 () { 
    return get_dm_laz2_prot1().ToString();}

    public string debug_name_dm_laz2_prot1 () { 
    return "��_���2_����1";}

// ��_���2_����2 (������2�-�������2/�������),   Bool, %M534.6   reg = M  width = Bit
    public bool get_dm_laz2_prot2 ()
    { return (bool) m_mem.getMBit(534, 6); }

    public void set_dm_laz2_prot2 (bool val)
    { m_mem.setMBit(534, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_laz2_prot2 to " + val.ToString());}

    public bool sets_dm_laz2_prot2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_laz2_prot2 (val);
    return true;}

    public string gets_dm_laz2_prot2 () { 
    return get_dm_laz2_prot2().ToString();}

    public string debug_name_dm_laz2_prot2 () { 
    return "��_���2_����2";}

// ��_���2_����3 (������2�-�������3/�������),   Bool, %M534.7   reg = M  width = Bit
    public bool get_dm_laz2_prot3 ()
    { return (bool) m_mem.getMBit(534, 7); }

    public void set_dm_laz2_prot3 (bool val)
    { m_mem.setMBit(534, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_laz2_prot3 to " + val.ToString());}

    public bool sets_dm_laz2_prot3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_laz2_prot3 (val);
    return true;}

    public string gets_dm_laz2_prot3 () { 
    return get_dm_laz2_prot3().ToString();}

    public string debug_name_dm_laz2_prot3 () { 
    return "��_���2_����3";}

// ��_�������_���� (��������������-���������/�������),   Bool, %M535.2   reg = M  width = Bit
    public bool get_dm_karpraw_konc ()
    { return (bool) m_mem.getMBit(535, 2); }

    public void set_dm_karpraw_konc (bool val)
    { m_mem.setMBit(535, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_karpraw_konc to " + val.ToString());}

    public bool sets_dm_karpraw_konc ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_karpraw_konc (val);
    return true;}

    public string gets_dm_karpraw_konc () { 
    return get_dm_karpraw_konc().ToString();}

    public string debug_name_dm_karpraw_konc () { 
    return "��_�������_����";}

// ��_������_���� (�������������-���������/�������),   Bool, %M535.3   reg = M  width = Bit
    public bool get_dm_karlew_konc ()
    { return (bool) m_mem.getMBit(535, 3); }

    public void set_dm_karlew_konc (bool val)
    { m_mem.setMBit(535, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_karlew_konc to " + val.ToString());}

    public bool sets_dm_karlew_konc ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_karlew_konc (val);
    return true;}

    public string gets_dm_karlew_konc () { 
    return get_dm_karlew_konc().ToString();}

    public string debug_name_dm_karlew_konc () { 
    return "��_������_����";}

// ���������� (����������/UDEFINED),   Bool, %M535.4   reg = M  width = Bit
    public bool get_razreshenie ()
    { return (bool) m_mem.getMBit(535, 4); }

    public void set_razreshenie (bool val)
    { m_mem.setMBit(535, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set razreshenie to " + val.ToString());}

    public bool sets_razreshenie ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_razreshenie (val);
    return true;}

    public string gets_razreshenie () { 
    return get_razreshenie().ToString();}

    public string debug_name_razreshenie () { 
    return "����������";}

// ���������� (����������/UDEFINED),   Bool, %M535.5   reg = M  width = Bit
    public bool get_gotownost ()
    { return (bool) m_mem.getMBit(535, 5); }

    public void set_gotownost (bool val)
    { m_mem.setMBit(535, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set gotownost to " + val.ToString());}

    public bool sets_gotownost ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_gotownost (val);
    return true;}

    public string gets_gotownost () { 
    return get_gotownost().ToString();}

    public string debug_name_gotownost () { 
    return "����������";}

public enum local_dm{
dm_stol_abs_domgot,
dm_laz1_prot1,
dm_laz1_prot2,
dm_laz1_prot3,
dm_laz2_prot1,
dm_laz2_prot2,
dm_laz2_prot3,
dm_karpraw_konc,
dm_karlew_konc,
razreshenie,
gotownost,
};

public gTags[] group_dm = {
gTags.dm_stol_abs_domgot,
gTags.dm_laz1_prot1,
gTags.dm_laz1_prot2,
gTags.dm_laz1_prot3,
gTags.dm_laz2_prot1,
gTags.dm_laz2_prot2,
gTags.dm_laz2_prot3,
gTags.dm_karpraw_konc,
gTags.dm_karlew_konc,
gTags.razreshenie,
gTags.gotownost,
};

//-----------------------------------------------------------------------------
//tags/ind.xml
//-----------------------------------------------------------------------------
// ���_����1_��� (���������1�-�����������/������),   Int, %MW608   reg = M  width = UInt16
    public Int16 get_ind_skan1_ohl ()
    { return (Int16) m_mem.getMUInt16(608); }

    public void set_ind_skan1_ohl (Int16 val)
    { m_mem.setMUInt16(608, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ind_skan1_ohl to " + val.ToString());}

    public bool sets_ind_skan1_ohl ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ind_skan1_ohl (val);
    return true;}

    public string gets_ind_skan1_ohl () { 
    return get_ind_skan1_ohl().ToString();}

    public string debug_name_ind_skan1_ohl () { 
    return "���_����1_���";}

// ���_����2_��� (���������2�-�����������/������),   Int, %MW610   reg = M  width = UInt16
    public Int16 get_ind_skan2_ohl ()
    { return (Int16) m_mem.getMUInt16(610); }

    public void set_ind_skan2_ohl (Int16 val)
    { m_mem.setMUInt16(610, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ind_skan2_ohl to " + val.ToString());}

    public bool sets_ind_skan2_ohl ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ind_skan2_ohl (val);
    return true;}

    public string gets_ind_skan2_ohl () { 
    return get_ind_skan2_ohl().ToString();}

    public string debug_name_ind_skan2_ohl () { 
    return "���_����2_���";}

// ���_���1_��� (������1�-�����������/������),   Int, %MW612   reg = M  width = UInt16
    public Int16 get_ind_laz1_ohl ()
    { return (Int16) m_mem.getMUInt16(612); }

    public void set_ind_laz1_ohl (Int16 val)
    { m_mem.setMUInt16(612, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ind_laz1_ohl to " + val.ToString());}

    public bool sets_ind_laz1_ohl ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ind_laz1_ohl (val);
    return true;}

    public string gets_ind_laz1_ohl () { 
    return get_ind_laz1_ohl().ToString();}

    public string debug_name_ind_laz1_ohl () { 
    return "���_���1_���";}

// ���_���2_��� (������2�-�����������/������),   Int, %MW614   reg = M  width = UInt16
    public Int16 get_ind_laz2_ohl ()
    { return (Int16) m_mem.getMUInt16(614); }

    public void set_ind_laz2_ohl (Int16 val)
    { m_mem.setMUInt16(614, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ind_laz2_ohl to " + val.ToString());}

    public bool sets_ind_laz2_ohl ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ind_laz2_ohl (val);
    return true;}

    public string gets_ind_laz2_ohl () { 
    return get_ind_laz2_ohl().ToString();}

    public string debug_name_ind_laz2_ohl () { 
    return "���_���2_���";}

// ���_�������� (��������������������/������),   Int, %MW640   reg = M  width = UInt16
    public Int16 get_ind_kislorod ()
    { return (Int16) m_mem.getMUInt16(640); }

    public void set_ind_kislorod (Int16 val)
    { m_mem.setMUInt16(640, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ind_kislorod to " + val.ToString());}

    public bool sets_ind_kislorod ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ind_kislorod (val);
    return true;}

    public string gets_ind_kislorod () { 
    return get_ind_kislorod().ToString();}

    public string debug_name_ind_kislorod () { 
    return "���_��������";}

// ���_������� (����������������/������),   Int, %MW682   reg = M  width = UInt16
    public Int16 get_ind_dawlkam ()
    { return (Int16) m_mem.getMUInt16(682); }

    public void set_ind_dawlkam (Int16 val)
    { m_mem.setMUInt16(682, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ind_dawlkam to " + val.ToString());}

    public bool sets_ind_dawlkam ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ind_dawlkam (val);
    return true;}

    public string gets_ind_dawlkam () { 
    return get_ind_dawlkam().ToString();}

    public string debug_name_ind_dawlkam () { 
    return "���_�������";}

public enum local_ind{
ind_skan1_ohl,
ind_skan2_ohl,
ind_laz1_ohl,
ind_laz2_ohl,
ind_kislorod,
ind_dawlkam,
};

public gTags[] group_ind = {
gTags.ind_skan1_ohl,
gTags.ind_skan2_ohl,
gTags.ind_laz1_ohl,
gTags.ind_laz2_ohl,
gTags.ind_kislorod,
gTags.ind_dawlkam,
};

//-----------------------------------------------------------------------------
//tags/usta.xml
//-----------------------------------------------------------------------------
// ���_����_���_��� (��������/����),   Real, %MD436   reg = M  width = UInt32
    public float get_ust_stol_abs_poz ()
    { return (float) m_mem.getMFloat(436); }

    public void set_ust_stol_abs_poz (float val)
    { m_mem.setMFloat(436, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_abs_poz to " + val.ToString());}

    public bool sets_ust_stol_abs_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_abs_poz (val);
    return true;}

    public string gets_ust_stol_abs_poz () { 
    return get_ust_stol_abs_poz().ToString();}

    public string debug_name_ust_stol_abs_poz () { 
    return "���_����_���_���";}

// ���_����_���� (���������/����),   Real, %MD424   reg = M  width = UInt32
    public float get_ust_stol_skor ()
    { return (float) m_mem.getMFloat(424); }

    public void set_ust_stol_skor (float val)
    { m_mem.setMFloat(424, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_skor to " + val.ToString());}

    public bool sets_ust_stol_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_skor (val);
    return true;}

    public string gets_ust_stol_skor () { 
    return get_ust_stol_skor().ToString();}

    public string debug_name_ust_stol_skor () { 
    return "���_����_����";}

// ���_����_���_����� (�����������/����),   Real, %MD448   reg = M  width = UInt32
    public float get_ust_stol_otn_rasst ()
    { return (float) m_mem.getMFloat(448); }

    public void set_ust_stol_otn_rasst (float val)
    { m_mem.setMFloat(448, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_otn_rasst to " + val.ToString());}

    public bool sets_ust_stol_otn_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_otn_rasst (val);
    return true;}

    public string gets_ust_stol_otn_rasst () { 
    return get_ust_stol_otn_rasst().ToString();}

    public string debug_name_ust_stol_otn_rasst () { 
    return "���_����_���_�����";}

// ���_���1_���� (���������/�����������),   Real, %MD476   reg = M  width = UInt32
    public float get_ust_tjen1_moschn ()
    { return (float) m_mem.getMFloat(476); }

    public void set_ust_tjen1_moschn (float val)
    { m_mem.setMFloat(476, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen1_moschn to " + val.ToString());}

    public bool sets_ust_tjen1_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen1_moschn (val);
    return true;}

    public string gets_ust_tjen1_moschn () { 
    return get_ust_tjen1_moschn().ToString();}

    public string debug_name_ust_tjen1_moschn () { 
    return "���_���1_����";}

// ���_���2_���� (���������/�����������),   Real, %MD480   reg = M  width = UInt32
    public float get_ust_tjen2_moschn ()
    { return (float) m_mem.getMFloat(480); }

    public void set_ust_tjen2_moschn (float val)
    { m_mem.setMFloat(480, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen2_moschn to " + val.ToString());}

    public bool sets_ust_tjen2_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen2_moschn (val);
    return true;}

    public string gets_ust_tjen2_moschn () { 
    return get_ust_tjen2_moschn().ToString();}

    public string debug_name_ust_tjen2_moschn () { 
    return "���_���2_����";}

// ���_���3_���� (���������/�����������),   Real, %MD484   reg = M  width = UInt32
    public float get_ust_tjen3_moschn ()
    { return (float) m_mem.getMFloat(484); }

    public void set_ust_tjen3_moschn (float val)
    { m_mem.setMFloat(484, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen3_moschn to " + val.ToString());}

    public bool sets_ust_tjen3_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen3_moschn (val);
    return true;}

    public string gets_ust_tjen3_moschn () { 
    return get_ust_tjen3_moschn().ToString();}

    public string debug_name_ust_tjen3_moschn () { 
    return "���_���3_����";}

// ���_���1_���� (������������/�����������),   Real, %MD488   reg = M  width = UInt32
    public float get_ust_tjen1_temp ()
    { return (float) m_mem.getMFloat(488); }

    public void set_ust_tjen1_temp (float val)
    { m_mem.setMFloat(488, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen1_temp to " + val.ToString());}

    public bool sets_ust_tjen1_temp ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen1_temp (val);
    return true;}

    public string gets_ust_tjen1_temp () { 
    return get_ust_tjen1_temp().ToString();}

    public string debug_name_ust_tjen1_temp () { 
    return "���_���1_����";}

// ���_���2_���� (������������/�����������),   Real, %MD296   reg = M  width = UInt32
    public float get_ust_tjen2_temp ()
    { return (float) m_mem.getMFloat(296); }

    public void set_ust_tjen2_temp (float val)
    { m_mem.setMFloat(296, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen2_temp to " + val.ToString());}

    public bool sets_ust_tjen2_temp ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen2_temp (val);
    return true;}

    public string gets_ust_tjen2_temp () { 
    return get_ust_tjen2_temp().ToString();}

    public string debug_name_ust_tjen2_temp () { 
    return "���_���2_����";}

// ���_���3_���� (������������/�����������),   Real, %MD300   reg = M  width = UInt32
    public float get_ust_tjen3_temp ()
    { return (float) m_mem.getMFloat(300); }

    public void set_ust_tjen3_temp (float val)
    { m_mem.setMFloat(300, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen3_temp to " + val.ToString());}

    public bool sets_ust_tjen3_temp ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen3_temp (val);
    return true;}

    public string gets_ust_tjen3_temp () { 
    return get_ust_tjen3_temp().ToString();}

    public string debug_name_ust_tjen3_temp () { 
    return "���_���3_����";}

// ���_������_���� (��������������-���������/�������),   Real, %MD304   reg = M  width = UInt32
    public float get_ust_karlew_skor ()
    { return (float) m_mem.getMFloat(304); }

    public void set_ust_karlew_skor (float val)
    { m_mem.setMFloat(304, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karlew_skor to " + val.ToString());}

    public bool sets_ust_karlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karlew_skor (val);
    return true;}

    public string gets_ust_karlew_skor () { 
    return get_ust_karlew_skor().ToString();}

    public string debug_name_ust_karlew_skor () { 
    return "���_������_����";}

// ���_������_���_���� (��������������-�����������/�������),   Real, %MD308   reg = M  width = UInt32
    public float get_ust_karlew_otn_rast ()
    { return (float) m_mem.getMFloat(308); }

    public void set_ust_karlew_otn_rast (float val)
    { m_mem.setMFloat(308, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karlew_otn_rast to " + val.ToString());}

    public bool sets_ust_karlew_otn_rast ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karlew_otn_rast (val);
    return true;}

    public string gets_ust_karlew_otn_rast () { 
    return get_ust_karlew_otn_rast().ToString();}

    public string debug_name_ust_karlew_otn_rast () { 
    return "���_������_���_����";}

// ���_������_���_��� (��������������-��������/�������),   Real, %MD312   reg = M  width = UInt32
    public float get_ust_karlew_abs_poz ()
    { return (float) m_mem.getMFloat(312); }

    public void set_ust_karlew_abs_poz (float val)
    { m_mem.setMFloat(312, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karlew_abs_poz to " + val.ToString());}

    public bool sets_ust_karlew_abs_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karlew_abs_poz (val);
    return true;}

    public string gets_ust_karlew_abs_poz () { 
    return get_ust_karlew_abs_poz().ToString();}

    public string debug_name_ust_karlew_abs_poz () { 
    return "���_������_���_���";}

// ���_�������_���� (���������������-���������/�������),   Real, %MD316   reg = M  width = UInt32
    public float get_ust_karpraw_skor ()
    { return (float) m_mem.getMFloat(316); }

    public void set_ust_karpraw_skor (float val)
    { m_mem.setMFloat(316, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karpraw_skor to " + val.ToString());}

    public bool sets_ust_karpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karpraw_skor (val);
    return true;}

    public string gets_ust_karpraw_skor () { 
    return get_ust_karpraw_skor().ToString();}

    public string debug_name_ust_karpraw_skor () { 
    return "���_�������_����";}

// ���_�������_���_���� (���������������-�����������/�������),   Real, %MD320   reg = M  width = UInt32
    public float get_ust_karpraw_otn_rast ()
    { return (float) m_mem.getMFloat(320); }

    public void set_ust_karpraw_otn_rast (float val)
    { m_mem.setMFloat(320, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karpraw_otn_rast to " + val.ToString());}

    public bool sets_ust_karpraw_otn_rast ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karpraw_otn_rast (val);
    return true;}

    public string gets_ust_karpraw_otn_rast () { 
    return get_ust_karpraw_otn_rast().ToString();}

    public string debug_name_ust_karpraw_otn_rast () { 
    return "���_�������_���_����";}

// ���_�������_���_��� (���������������-��������/�������),   Real, %MD324   reg = M  width = UInt32
    public float get_ust_karpraw_abs_poz ()
    { return (float) m_mem.getMFloat(324); }

    public void set_ust_karpraw_abs_poz (float val)
    { m_mem.setMFloat(324, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karpraw_abs_poz to " + val.ToString());}

    public bool sets_ust_karpraw_abs_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karpraw_abs_poz (val);
    return true;}

    public string gets_ust_karpraw_abs_poz () { 
    return get_ust_karpraw_abs_poz().ToString();}

    public string debug_name_ust_karpraw_abs_poz () { 
    return "���_�������_���_���";}

// ���_�������_���� (���������������-���������/��������),   Real, %MD328   reg = M  width = UInt32
    public float get_ust_barpraw_skor ()
    { return (float) m_mem.getMFloat(328); }

    public void set_ust_barpraw_skor (float val)
    { m_mem.setMFloat(328, (float) val); 
      Log.Write(LogLevel.Info, "set ust_barpraw_skor to " + val.ToString());}

    public bool sets_ust_barpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_barpraw_skor (val);
    return true;}

    public string gets_ust_barpraw_skor () { 
    return get_ust_barpraw_skor().ToString();}

    public string debug_name_ust_barpraw_skor () { 
    return "���_�������_����";}

// ���_������_���� (��������������-���������/��������),   Real, %MD340   reg = M  width = UInt32
    public float get_ust_barlew_skor ()
    { return (float) m_mem.getMFloat(340); }

    public void set_ust_barlew_skor (float val)
    { m_mem.setMFloat(340, (float) val); 
      Log.Write(LogLevel.Info, "set ust_barlew_skor to " + val.ToString());}

    public bool sets_ust_barlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_barlew_skor (val);
    return true;}

    public string gets_ust_barlew_skor () { 
    return get_ust_barlew_skor().ToString();}

    public string debug_name_ust_barlew_skor () { 
    return "���_������_����";}

// ���_������_����� (�������������-������/��������),   Real, %MD352   reg = M  width = UInt32
    public float get_ust_dozlew_wremq ()
    { return (float) m_mem.getMFloat(352); }

    public void set_ust_dozlew_wremq (float val)
    { m_mem.setMFloat(352, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozlew_wremq to " + val.ToString());}

    public bool sets_ust_dozlew_wremq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozlew_wremq (val);
    return true;}

    public string gets_ust_dozlew_wremq () { 
    return get_ust_dozlew_wremq().ToString();}

    public string debug_name_ust_dozlew_wremq () { 
    return "���_������_�����";}

// ���_�������_����� (��������������-������/��������),   Real, %MD356   reg = M  width = UInt32
    public float get_ust_dozpraw_wremq ()
    { return (float) m_mem.getMFloat(356); }

    public void set_ust_dozpraw_wremq (float val)
    { m_mem.setMFloat(356, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozpraw_wremq to " + val.ToString());}

    public bool sets_ust_dozpraw_wremq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozpraw_wremq (val);
    return true;}

    public string gets_ust_dozpraw_wremq () { 
    return get_ust_dozpraw_wremq().ToString();}

    public string debug_name_ust_dozpraw_wremq () { 
    return "���_�������_�����";}

// ���_�������_����� (����������������-�����������/���������),   Real, %MD360   reg = M  width = UInt32
    public float get_ust_tolklew_rasst ()
    { return (float) m_mem.getMFloat(360); }

    public void set_ust_tolklew_rasst (float val)
    { m_mem.setMFloat(360, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolklew_rasst to " + val.ToString());}

    public bool sets_ust_tolklew_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolklew_rasst (val);
    return true;}

    public string gets_ust_tolklew_rasst () { 
    return get_ust_tolklew_rasst().ToString();}

    public string debug_name_ust_tolklew_rasst () { 
    return "���_�������_�����";}

// ���_��������_����� (�����������������-�����������/���������),   Real, %MD364   reg = M  width = UInt32
    public float get_ust_tolkpraw_rasst ()
    { return (float) m_mem.getMFloat(364); }

    public void set_ust_tolkpraw_rasst (float val)
    { m_mem.setMFloat(364, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolkpraw_rasst to " + val.ToString());}

    public bool sets_ust_tolkpraw_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolkpraw_rasst (val);
    return true;}

    public string gets_ust_tolkpraw_rasst () { 
    return get_ust_tolkpraw_rasst().ToString();}

    public string debug_name_ust_tolkpraw_rasst () { 
    return "���_��������_�����";}

// ���_�������_���� (��������������-���������/��������),   Real, %MD368   reg = M  width = UInt32
    public float get_ust_dozpraw_skor ()
    { return (float) m_mem.getMFloat(368); }

    public void set_ust_dozpraw_skor (float val)
    { m_mem.setMFloat(368, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozpraw_skor to " + val.ToString());}

    public bool sets_ust_dozpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozpraw_skor (val);
    return true;}

    public string gets_ust_dozpraw_skor () { 
    return get_ust_dozpraw_skor().ToString();}

    public string debug_name_ust_dozpraw_skor () { 
    return "���_�������_����";}

// ���_������_���� (�������������-���������/��������),   Real, %MD372   reg = M  width = UInt32
    public float get_ust_dozlew_skor ()
    { return (float) m_mem.getMFloat(372); }

    public void set_ust_dozlew_skor (float val)
    { m_mem.setMFloat(372, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozlew_skor to " + val.ToString());}

    public bool sets_ust_dozlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozlew_skor (val);
    return true;}

    public string gets_ust_dozlew_skor () { 
    return get_ust_dozlew_skor().ToString();}

    public string debug_name_ust_dozlew_skor () { 
    return "���_������_����";}

// ���_�������_���� (����������������-���������/���������),   Real, %MD376   reg = M  width = UInt32
    public float get_ust_tolklew_skor ()
    { return (float) m_mem.getMFloat(376); }

    public void set_ust_tolklew_skor (float val)
    { m_mem.setMFloat(376, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolklew_skor to " + val.ToString());}

    public bool sets_ust_tolklew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolklew_skor (val);
    return true;}

    public string gets_ust_tolklew_skor () { 
    return get_ust_tolklew_skor().ToString();}

    public string debug_name_ust_tolklew_skor () { 
    return "���_�������_����";}

// ���_��������_���� (�����������������-���������/���������),   Real, %MD380   reg = M  width = UInt32
    public float get_ust_tolkpraw_skor ()
    { return (float) m_mem.getMFloat(380); }

    public void set_ust_tolkpraw_skor (float val)
    { m_mem.setMFloat(380, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolkpraw_skor to " + val.ToString());}

    public bool sets_ust_tolkpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolkpraw_skor (val);
    return true;}

    public string gets_ust_tolkpraw_skor () { 
    return get_ust_tolkpraw_skor().ToString();}

    public string debug_name_ust_tolkpraw_skor () { 
    return "���_��������_����";}

public enum local_usta{
ust_stol_abs_poz,
ust_stol_skor,
ust_stol_otn_rasst,
ust_tjen1_moschn,
ust_tjen2_moschn,
ust_tjen3_moschn,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
ust_karlew_skor,
ust_karlew_otn_rast,
ust_karlew_abs_poz,
ust_karpraw_skor,
ust_karpraw_otn_rast,
ust_karpraw_abs_poz,
ust_barpraw_skor,
ust_barlew_skor,
ust_dozlew_wremq,
ust_dozpraw_wremq,
ust_tolklew_rasst,
ust_tolkpraw_rasst,
ust_dozpraw_skor,
ust_dozlew_skor,
ust_tolklew_skor,
ust_tolkpraw_skor,
};

public gTags[] group_usta = {
gTags.ust_stol_abs_poz,
gTags.ust_stol_skor,
gTags.ust_stol_otn_rasst,
gTags.ust_tjen1_moschn,
gTags.ust_tjen2_moschn,
gTags.ust_tjen3_moschn,
gTags.ust_tjen1_temp,
gTags.ust_tjen2_temp,
gTags.ust_tjen3_temp,
gTags.ust_karlew_skor,
gTags.ust_karlew_otn_rast,
gTags.ust_karlew_abs_poz,
gTags.ust_karpraw_skor,
gTags.ust_karpraw_otn_rast,
gTags.ust_karpraw_abs_poz,
gTags.ust_barpraw_skor,
gTags.ust_barlew_skor,
gTags.ust_dozlew_wremq,
gTags.ust_dozpraw_wremq,
gTags.ust_tolklew_rasst,
gTags.ust_tolkpraw_rasst,
gTags.ust_dozpraw_skor,
gTags.ust_dozlew_skor,
gTags.ust_tolklew_skor,
gTags.ust_tolkpraw_skor,
};

//-----------------------------------------------------------------------------
//tags/outD.xml
//-----------------------------------------------------------------------------
// ����_����_��� (�/����),   Bool, %M500.4   reg = M  width = Bit
    public bool get_wyhd_stol_abs ()
    { return (bool) m_mem.getMBit(500, 4); }

    public void set_wyhd_stol_abs (bool val)
    { m_mem.setMBit(500, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_abs to " + val.ToString());}

    public bool sets_wyhd_stol_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_abs (val);
    return true;}

    public string gets_wyhd_stol_abs () { 
    return get_wyhd_stol_abs().ToString();}

    public string debug_name_wyhd_stol_abs () { 
    return "����_����_���";}

// ����_���1_��� (�/�����������),   Bool, %M503.2   reg = M  width = Bit
    public bool get_wyhd_tjen1_pit ()
    { return (bool) m_mem.getMBit(503, 2); }

    public void set_wyhd_tjen1_pit (bool val)
    { m_mem.setMBit(503, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tjen1_pit to " + val.ToString());}

    public bool sets_wyhd_tjen1_pit ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tjen1_pit (val);
    return true;}

    public string gets_wyhd_tjen1_pit () { 
    return get_wyhd_tjen1_pit().ToString();}

    public string debug_name_wyhd_tjen1_pit () { 
    return "����_���1_���";}

// ����_����_���_���� (�/����),   Bool, %M505.7   reg = M  width = Bit
    public bool get_wyhd_stol_otn_wniz ()
    { return (bool) m_mem.getMBit(505, 7); }

    public void set_wyhd_stol_otn_wniz (bool val)
    { m_mem.setMBit(505, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_otn_wniz to " + val.ToString());}

    public bool sets_wyhd_stol_otn_wniz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_otn_wniz (val);
    return true;}

    public string gets_wyhd_stol_otn_wniz () { 
    return get_wyhd_stol_otn_wniz().ToString();}

    public string debug_name_wyhd_stol_otn_wniz () { 
    return "����_����_���_����";}

// ����_����_���_����� (�/����),   Bool, %M506.0   reg = M  width = Bit
    public bool get_wyhd_stol_otn_wwerh ()
    { return (bool) m_mem.getMBit(506, 0); }

    public void set_wyhd_stol_otn_wwerh (bool val)
    { m_mem.setMBit(506, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_otn_wwerh to " + val.ToString());}

    public bool sets_wyhd_stol_otn_wwerh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_otn_wwerh (val);
    return true;}

    public string gets_wyhd_stol_otn_wwerh () { 
    return get_wyhd_stol_otn_wwerh().ToString();}

    public string debug_name_wyhd_stol_otn_wwerh () { 
    return "����_����_���_�����";}

// ����_���_���1 (�/������),   Bool, %M506.5   reg = M  width = Bit
    public bool get_wyhd_laz_pit1 ()
    { return (bool) m_mem.getMBit(506, 5); }

    public void set_wyhd_laz_pit1 (bool val)
    { m_mem.setMBit(506, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_laz_pit1 to " + val.ToString());}

    public bool sets_wyhd_laz_pit1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_laz_pit1 (val);
    return true;}

    public string gets_wyhd_laz_pit1 () { 
    return get_wyhd_laz_pit1().ToString();}

    public string debug_name_wyhd_laz_pit1 () { 
    return "����_���_���1";}

// ����_������1 (�/�������),   Bool, %M506.6   reg = M  width = Bit
    public bool get_wyhd_pitchil1 ()
    { return (bool) m_mem.getMBit(506, 6); }

    public void set_wyhd_pitchil1 (bool val)
    { m_mem.setMBit(506, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitchil1 to " + val.ToString());}

    public bool sets_wyhd_pitchil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitchil1 (val);
    return true;}

    public string gets_wyhd_pitchil1 () { 
    return get_wyhd_pitchil1().ToString();}

    public string debug_name_wyhd_pitchil1 () { 
    return "����_������1";}

// ����_������2 (�/�������),   Bool, %M506.7   reg = M  width = Bit
    public bool get_wyhd_pitchil2 ()
    { return (bool) m_mem.getMBit(506, 7); }

    public void set_wyhd_pitchil2 (bool val)
    { m_mem.setMBit(506, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitchil2 to " + val.ToString());}

    public bool sets_wyhd_pitchil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitchil2 (val);
    return true;}

    public string gets_wyhd_pitchil2 () { 
    return get_wyhd_pitchil2().ToString();}

    public string debug_name_wyhd_pitchil2 () { 
    return "����_������2";}

// ����_������ (�/�������),   Bool, %M507.2   reg = M  width = Bit
    public bool get_wyhd_pitmps ()
    { return (bool) m_mem.getMBit(507, 2); }

    public void set_wyhd_pitmps (bool val)
    { m_mem.setMBit(507, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitmps to " + val.ToString());}

    public bool sets_wyhd_pitmps ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitmps (val);
    return true;}

    public string gets_wyhd_pitmps () { 
    return get_wyhd_pitmps().ToString();}

    public string debug_name_wyhd_pitmps () { 
    return "����_������";}

// ����_������ (�/������������),   Bool, %M507.3   reg = M  width = Bit
    public bool get_wyhd_pitrec ()
    { return (bool) m_mem.getMBit(507, 3); }

    public void set_wyhd_pitrec (bool val)
    { m_mem.setMBit(507, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitrec to " + val.ToString());}

    public bool sets_wyhd_pitrec ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitrec (val);
    return true;}

    public string gets_wyhd_pitrec () { 
    return get_wyhd_pitrec().ToString();}

    public string debug_name_wyhd_pitrec () { 
    return "����_������";}

// ����_��1 (�/������������),   Bool, %M507.4   reg = M  width = Bit
    public bool get_wyhd_kv1 ()
    { return (bool) m_mem.getMBit(507, 4); }

    public void set_wyhd_kv1 (bool val)
    { m_mem.setMBit(507, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kv1 to " + val.ToString());}

    public bool sets_wyhd_kv1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kv1 (val);
    return true;}

    public string gets_wyhd_kv1 () { 
    return get_wyhd_kv1().ToString();}

    public string debug_name_wyhd_kv1 () { 
    return "����_��1";}

// ����_��2 (�/������������),   Bool, %M507.5   reg = M  width = Bit
    public bool get_wyhd_kv2 ()
    { return (bool) m_mem.getMBit(507, 5); }

    public void set_wyhd_kv2 (bool val)
    { m_mem.setMBit(507, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kv2 to " + val.ToString());}

    public bool sets_wyhd_kv2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kv2 (val);
    return true;}

    public string gets_wyhd_kv2 () { 
    return get_wyhd_kv2().ToString();}

    public string debug_name_wyhd_kv2 () { 
    return "����_��2";}

// ����_��9 (�/������),   Bool, %M507.6   reg = M  width = Bit
    public bool get_wyhd_kje9 ()
    { return (bool) m_mem.getMBit(507, 6); }

    public void set_wyhd_kje9 (bool val)
    { m_mem.setMBit(507, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kje9 to " + val.ToString());}

    public bool sets_wyhd_kje9 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kje9 (val);
    return true;}

    public string gets_wyhd_kje9 () { 
    return get_wyhd_kje9().ToString();}

    public string debug_name_wyhd_kje9 () { 
    return "����_��9";}

// ����_��10 (�/������),   Bool, %M507.7   reg = M  width = Bit
    public bool get_wyhd_kje10 ()
    { return (bool) m_mem.getMBit(507, 7); }

    public void set_wyhd_kje10 (bool val)
    { m_mem.setMBit(507, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kje10 to " + val.ToString());}

    public bool sets_wyhd_kje10 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kje10 (val);
    return true;}

    public string gets_wyhd_kje10 () { 
    return get_wyhd_kje10().ToString();}

    public string debug_name_wyhd_kje10 () { 
    return "����_��10";}

// ����_�������_��� (�/�������),   Bool, %M508.0   reg = M  width = Bit
    public bool get_wyhd_karpraw_abs ()
    { return (bool) m_mem.getMBit(508, 0); }

    public void set_wyhd_karpraw_abs (bool val)
    { m_mem.setMBit(508, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karpraw_abs to " + val.ToString());}

    public bool sets_wyhd_karpraw_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karpraw_abs (val);
    return true;}

    public string gets_wyhd_karpraw_abs () { 
    return get_wyhd_karpraw_abs().ToString();}

    public string debug_name_wyhd_karpraw_abs () { 
    return "����_�������_���";}

// ����_������_��� (�/�������),   Bool, %M508.1   reg = M  width = Bit
    public bool get_wyhd_karlew_abs ()
    { return (bool) m_mem.getMBit(508, 1); }

    public void set_wyhd_karlew_abs (bool val)
    { m_mem.setMBit(508, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karlew_abs to " + val.ToString());}

    public bool sets_wyhd_karlew_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karlew_abs (val);
    return true;}

    public string gets_wyhd_karlew_abs () { 
    return get_wyhd_karlew_abs().ToString();}

    public string debug_name_wyhd_karlew_abs () { 
    return "����_������_���";}

// ����_�������_���� (�/��������),   Bool, %M508.2   reg = M  width = Bit
    public bool get_wyhd_dozpraw_wper ()
    { return (bool) m_mem.getMBit(508, 2); }

    public void set_wyhd_dozpraw_wper (bool val)
    { m_mem.setMBit(508, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozpraw_wper to " + val.ToString());}

    public bool sets_wyhd_dozpraw_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozpraw_wper (val);
    return true;}

    public string gets_wyhd_dozpraw_wper () { 
    return get_wyhd_dozpraw_wper().ToString();}

    public string debug_name_wyhd_dozpraw_wper () { 
    return "����_�������_����";}

// ����_������_���� (�/��������),   Bool, %M508.3   reg = M  width = Bit
    public bool get_wyhd_dozlew_wper ()
    { return (bool) m_mem.getMBit(508, 3); }

    public void set_wyhd_dozlew_wper (bool val)
    { m_mem.setMBit(508, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozlew_wper to " + val.ToString());}

    public bool sets_wyhd_dozlew_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozlew_wper (val);
    return true;}

    public string gets_wyhd_dozlew_wper () { 
    return get_wyhd_dozlew_wper().ToString();}

    public string debug_name_wyhd_dozlew_wper () { 
    return "����_������_����";}

// ����_�������_����� (�/��������),   Bool, %M508.4   reg = M  width = Bit
    public bool get_wyhd_dozpraw_nazad ()
    { return (bool) m_mem.getMBit(508, 4); }

    public void set_wyhd_dozpraw_nazad (bool val)
    { m_mem.setMBit(508, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozpraw_nazad to " + val.ToString());}

    public bool sets_wyhd_dozpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozpraw_nazad (val);
    return true;}

    public string gets_wyhd_dozpraw_nazad () { 
    return get_wyhd_dozpraw_nazad().ToString();}

    public string debug_name_wyhd_dozpraw_nazad () { 
    return "����_�������_�����";}

// ����_������_����� (�/��������),   Bool, %M508.5   reg = M  width = Bit
    public bool get_wyhd_dozlew_nazad ()
    { return (bool) m_mem.getMBit(508, 5); }

    public void set_wyhd_dozlew_nazad (bool val)
    { m_mem.setMBit(508, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozlew_nazad to " + val.ToString());}

    public bool sets_wyhd_dozlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozlew_nazad (val);
    return true;}

    public string gets_wyhd_dozlew_nazad () { 
    return get_wyhd_dozlew_nazad().ToString();}

    public string debug_name_wyhd_dozlew_nazad () { 
    return "����_������_�����";}

// ����_����_�������� (�/����),   Bool, %M280.0   reg = M  width = Bit
    public bool get_wyhd_stol_peresch_t ()
    { return (bool) m_mem.getMBit(280, 0); }

    public void set_wyhd_stol_peresch_t (bool val)
    { m_mem.setMBit(280, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_peresch_t to " + val.ToString());}

    public bool sets_wyhd_stol_peresch_t ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_peresch_t (val);
    return true;}

    public string gets_wyhd_stol_peresch_t () { 
    return get_wyhd_stol_peresch_t().ToString();}

    public string debug_name_wyhd_stol_peresch_t () { 
    return "����_����_��������";}

// ����_������_����� (�/��������),   Bool, %M508.6   reg = M  width = Bit
    public bool get_wyhd_barlew_wper_d ()
    { return (bool) m_mem.getMBit(508, 6); }

    public void set_wyhd_barlew_wper_d (bool val)
    { m_mem.setMBit(508, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barlew_wper_d to " + val.ToString());}

    public bool sets_wyhd_barlew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barlew_wper_d (val);
    return true;}

    public string gets_wyhd_barlew_wper_d () { 
    return get_wyhd_barlew_wper_d().ToString();}

    public string debug_name_wyhd_barlew_wper_d () { 
    return "����_������_�����";}

// ����_�������_����� (�/��������),   Bool, %M508.7   reg = M  width = Bit
    public bool get_wyhd_barpraw_wper_d ()
    { return (bool) m_mem.getMBit(508, 7); }

    public void set_wyhd_barpraw_wper_d (bool val)
    { m_mem.setMBit(508, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barpraw_wper_d to " + val.ToString());}

    public bool sets_wyhd_barpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barpraw_wper_d (val);
    return true;}

    public string gets_wyhd_barpraw_wper_d () { 
    return get_wyhd_barpraw_wper_d().ToString();}

    public string debug_name_wyhd_barpraw_wper_d () { 
    return "����_�������_�����";}

// ����_������_����� (�/��������),   Bool, %M509.0   reg = M  width = Bit
    public bool get_wyhd_barlew_nazad ()
    { return (bool) m_mem.getMBit(509, 0); }

    public void set_wyhd_barlew_nazad (bool val)
    { m_mem.setMBit(509, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barlew_nazad to " + val.ToString());}

    public bool sets_wyhd_barlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barlew_nazad (val);
    return true;}

    public string gets_wyhd_barlew_nazad () { 
    return get_wyhd_barlew_nazad().ToString();}

    public string debug_name_wyhd_barlew_nazad () { 
    return "����_������_�����";}

// ����_�������_����� (�/��������),   Bool, %M509.1   reg = M  width = Bit
    public bool get_wyhd_barpraw_nazad ()
    { return (bool) m_mem.getMBit(509, 1); }

    public void set_wyhd_barpraw_nazad (bool val)
    { m_mem.setMBit(509, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barpraw_nazad to " + val.ToString());}

    public bool sets_wyhd_barpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barpraw_nazad (val);
    return true;}

    public string gets_wyhd_barpraw_nazad () { 
    return get_wyhd_barpraw_nazad().ToString();}

    public string debug_name_wyhd_barpraw_nazad () { 
    return "����_�������_�����";}

// ����_�������_����� (�/���������),   Bool, %M509.2   reg = M  width = Bit
    public bool get_wyhd_tolklew_wper_d ()
    { return (bool) m_mem.getMBit(509, 2); }

    public void set_wyhd_tolklew_wper_d (bool val)
    { m_mem.setMBit(509, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolklew_wper_d to " + val.ToString());}

    public bool sets_wyhd_tolklew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolklew_wper_d (val);
    return true;}

    public string gets_wyhd_tolklew_wper_d () { 
    return get_wyhd_tolklew_wper_d().ToString();}

    public string debug_name_wyhd_tolklew_wper_d () { 
    return "����_�������_�����";}

// ����_��������_����� (�/���������),   Bool, %M509.3   reg = M  width = Bit
    public bool get_wyhd_tolkpraw_wper_d ()
    { return (bool) m_mem.getMBit(509, 3); }

    public void set_wyhd_tolkpraw_wper_d (bool val)
    { m_mem.setMBit(509, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolkpraw_wper_d to " + val.ToString());}

    public bool sets_wyhd_tolkpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolkpraw_wper_d (val);
    return true;}

    public string gets_wyhd_tolkpraw_wper_d () { 
    return get_wyhd_tolkpraw_wper_d().ToString();}

    public string debug_name_wyhd_tolkpraw_wper_d () { 
    return "����_��������_�����";}

// ����_�������_����� (�/���������),   Bool, %M509.4   reg = M  width = Bit
    public bool get_wyhd_tolklew_nazad ()
    { return (bool) m_mem.getMBit(509, 4); }

    public void set_wyhd_tolklew_nazad (bool val)
    { m_mem.setMBit(509, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolklew_nazad to " + val.ToString());}

    public bool sets_wyhd_tolklew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolklew_nazad (val);
    return true;}

    public string gets_wyhd_tolklew_nazad () { 
    return get_wyhd_tolklew_nazad().ToString();}

    public string debug_name_wyhd_tolklew_nazad () { 
    return "����_�������_�����";}

// ����_��������_����� (�/���������),   Bool, %M509.5   reg = M  width = Bit
    public bool get_wyhd_tolkpraw_nazad ()
    { return (bool) m_mem.getMBit(509, 5); }

    public void set_wyhd_tolkpraw_nazad (bool val)
    { m_mem.setMBit(509, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolkpraw_nazad to " + val.ToString());}

    public bool sets_wyhd_tolkpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolkpraw_nazad (val);
    return true;}

    public string gets_wyhd_tolkpraw_nazad () { 
    return get_wyhd_tolkpraw_nazad().ToString();}

    public string debug_name_wyhd_tolkpraw_nazad () { 
    return "����_��������_�����";}

// ����_�������_���_����� (�/�������),   Bool, %M509.6   reg = M  width = Bit
    public bool get_wyhd_karpraw_otn_wper_d ()
    { return (bool) m_mem.getMBit(509, 6); }

    public void set_wyhd_karpraw_otn_wper_d (bool val)
    { m_mem.setMBit(509, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karpraw_otn_wper_d to " + val.ToString());}

    public bool sets_wyhd_karpraw_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karpraw_otn_wper_d (val);
    return true;}

    public string gets_wyhd_karpraw_otn_wper_d () { 
    return get_wyhd_karpraw_otn_wper_d().ToString();}

    public string debug_name_wyhd_karpraw_otn_wper_d () { 
    return "����_�������_���_�����";}

// ����_�������_���_����� (�/�������),   Bool, %M509.7   reg = M  width = Bit
    public bool get_wyhd_karpraw_otn_nazad ()
    { return (bool) m_mem.getMBit(509, 7); }

    public void set_wyhd_karpraw_otn_nazad (bool val)
    { m_mem.setMBit(509, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karpraw_otn_nazad to " + val.ToString());}

    public bool sets_wyhd_karpraw_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karpraw_otn_nazad (val);
    return true;}

    public string gets_wyhd_karpraw_otn_nazad () { 
    return get_wyhd_karpraw_otn_nazad().ToString();}

    public string debug_name_wyhd_karpraw_otn_nazad () { 
    return "����_�������_���_�����";}

// ����_������_���_����� (�/�������),   Bool, %M510.0   reg = M  width = Bit
    public bool get_wyhd_karlew_otn_wper_d ()
    { return (bool) m_mem.getMBit(510, 0); }

    public void set_wyhd_karlew_otn_wper_d (bool val)
    { m_mem.setMBit(510, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karlew_otn_wper_d to " + val.ToString());}

    public bool sets_wyhd_karlew_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karlew_otn_wper_d (val);
    return true;}

    public string gets_wyhd_karlew_otn_wper_d () { 
    return get_wyhd_karlew_otn_wper_d().ToString();}

    public string debug_name_wyhd_karlew_otn_wper_d () { 
    return "����_������_���_�����";}

// ����_������_���_����� (�/�������),   Bool, %M510.1   reg = M  width = Bit
    public bool get_wyhd_karlew_otn_nazad ()
    { return (bool) m_mem.getMBit(510, 1); }

    public void set_wyhd_karlew_otn_nazad (bool val)
    { m_mem.setMBit(510, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karlew_otn_nazad to " + val.ToString());}

    public bool sets_wyhd_karlew_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karlew_otn_nazad (val);
    return true;}

    public string gets_wyhd_karlew_otn_nazad () { 
    return get_wyhd_karlew_otn_nazad().ToString();}

    public string debug_name_wyhd_karlew_otn_nazad () { 
    return "����_������_���_�����";}

// ����_�������� (�/��������),   Bool, %M510.2   reg = M  width = Bit
    public bool get_wyhd_klbarlew ()
    { return (bool) m_mem.getMBit(510, 2); }

    public void set_wyhd_klbarlew (bool val)
    { m_mem.setMBit(510, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klbarlew to " + val.ToString());}

    public bool sets_wyhd_klbarlew ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klbarlew (val);
    return true;}

    public string gets_wyhd_klbarlew () { 
    return get_wyhd_klbarlew().ToString();}

    public string debug_name_wyhd_klbarlew () { 
    return "����_��������";}

// ����_��������� (�/��������),   Bool, %M510.3   reg = M  width = Bit
    public bool get_wyhd_klbarpraw ()
    { return (bool) m_mem.getMBit(510, 3); }

    public void set_wyhd_klbarpraw (bool val)
    { m_mem.setMBit(510, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klbarpraw to " + val.ToString());}

    public bool sets_wyhd_klbarpraw ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klbarpraw (val);
    return true;}

    public string gets_wyhd_klbarpraw () { 
    return get_wyhd_klbarpraw().ToString();}

    public string debug_name_wyhd_klbarpraw () { 
    return "����_���������";}

// ����_���������� (�/��������),   Bool, %M510.4   reg = M  width = Bit
    public bool get_wyhd_nasotkgaza ()
    { return (bool) m_mem.getMBit(510, 4); }

    public void set_wyhd_nasotkgaza (bool val)
    { m_mem.setMBit(510, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_nasotkgaza to " + val.ToString());}

    public bool sets_wyhd_nasotkgaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_nasotkgaza (val);
    return true;}

    public string gets_wyhd_nasotkgaza () { 
    return get_wyhd_nasotkgaza().ToString();}

    public string debug_name_wyhd_nasotkgaza () { 
    return "����_����������";}

// ����_��_����_���1 (�/���������������������),   Bool, %M522.0   reg = M  width = Bit
    public bool get_wyhd_tp_sloj_rab1 ()
    { return (bool) m_mem.getMBit(522, 0); }

    public void set_wyhd_tp_sloj_rab1 (bool val)
    { m_mem.setMBit(522, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_sloj_rab1 to " + val.ToString());}

    public bool sets_wyhd_tp_sloj_rab1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_sloj_rab1 (val);
    return true;}

    public string gets_wyhd_tp_sloj_rab1 () { 
    return get_wyhd_tp_sloj_rab1().ToString();}

    public string debug_name_wyhd_tp_sloj_rab1 () { 
    return "����_��_����_���1";}

// ����_��_������� (�/���������������������),   Bool, %M518.5   reg = M  width = Bit
    public bool get_wyhd_tp_process ()
    { return (bool) m_mem.getMBit(518, 5); }

    public void set_wyhd_tp_process (bool val)
    { m_mem.setMBit(518, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_process to " + val.ToString());}

    public bool sets_wyhd_tp_process ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_process (val);
    return true;}

    public string gets_wyhd_tp_process () { 
    return get_wyhd_tp_process().ToString();}

    public string debug_name_wyhd_tp_process () { 
    return "����_��_�������";}

// ����_���_���2 (�/������),   Bool, %M510.5   reg = M  width = Bit
    public bool get_wyhd_laz_pit2 ()
    { return (bool) m_mem.getMBit(510, 5); }

    public void set_wyhd_laz_pit2 (bool val)
    { m_mem.setMBit(510, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_laz_pit2 to " + val.ToString());}

    public bool sets_wyhd_laz_pit2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_laz_pit2 (val);
    return true;}

    public string gets_wyhd_laz_pit2 () { 
    return get_wyhd_laz_pit2().ToString();}

    public string debug_name_wyhd_laz_pit2 () { 
    return "����_���_���2";}

// ����_��_����_���2 (�/���������������������),   Bool, %M522.1   reg = M  width = Bit
    public bool get_wyhd_tp_sloj_rab2 ()
    { return (bool) m_mem.getMBit(522, 1); }

    public void set_wyhd_tp_sloj_rab2 (bool val)
    { m_mem.setMBit(522, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_sloj_rab2 to " + val.ToString());}

    public bool sets_wyhd_tp_sloj_rab2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_sloj_rab2 (val);
    return true;}

    public string gets_wyhd_tp_sloj_rab2 () { 
    return get_wyhd_tp_sloj_rab2().ToString();}

    public string debug_name_wyhd_tp_sloj_rab2 () { 
    return "����_��_����_���2";}

// ����_��_����_���3 (�/���������������������),   Bool, %M522.2   reg = M  width = Bit
    public bool get_wyhd_tp_sloj_rab3 ()
    { return (bool) m_mem.getMBit(522, 2); }

    public void set_wyhd_tp_sloj_rab3 (bool val)
    { m_mem.setMBit(522, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_sloj_rab3 to " + val.ToString());}

    public bool sets_wyhd_tp_sloj_rab3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_sloj_rab3 (val);
    return true;}

    public string gets_wyhd_tp_sloj_rab3 () { 
    return get_wyhd_tp_sloj_rab3().ToString();}

    public string debug_name_wyhd_tp_sloj_rab3 () { 
    return "����_��_����_���3";}

// ����_���������� (�/������),   Bool, %M280.1   reg = M  width = Bit
    public bool get_wyhd_blokirowki ()
    { return (bool) m_mem.getMBit(280, 1); }

    public void set_wyhd_blokirowki (bool val)
    { m_mem.setMBit(280, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_blokirowki to " + val.ToString());}

    public bool sets_wyhd_blokirowki ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_blokirowki (val);
    return true;}

    public string gets_wyhd_blokirowki () { 
    return get_wyhd_blokirowki().ToString();}

    public string debug_name_wyhd_blokirowki () { 
    return "����_����������";}

// ����_��_����� (�/���������������������),   Bool, %M522.3   reg = M  width = Bit
    public bool get_wyhd_tp_pauza ()
    { return (bool) m_mem.getMBit(522, 3); }

    public void set_wyhd_tp_pauza (bool val)
    { m_mem.setMBit(522, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_pauza to " + val.ToString());}

    public bool sets_wyhd_tp_pauza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_pauza (val);
    return true;}

    public string gets_wyhd_tp_pauza () { 
    return get_wyhd_tp_pauza().ToString();}

    public string debug_name_wyhd_tp_pauza () { 
    return "����_��_�����";}

// ����_��������� (�/������������),   Bool, %M522.4   reg = M  width = Bit
    public bool get_wyhd_klnapgaza ()
    { return (bool) m_mem.getMBit(522, 4); }

    public void set_wyhd_klnapgaza (bool val)
    { m_mem.setMBit(522, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klnapgaza to " + val.ToString());}

    public bool sets_wyhd_klnapgaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klnapgaza (val);
    return true;}

    public string gets_wyhd_klnapgaza () { 
    return get_wyhd_klnapgaza().ToString();}

    public string debug_name_wyhd_klnapgaza () { 
    return "����_���������";}

// ����_��_������������������� (�/���������������������),   Bool, %M523.0   reg = M  width = Bit
    public bool get_wyhd_tp_pauzaposleraskladki ()
    { return (bool) m_mem.getMBit(523, 0); }

    public void set_wyhd_tp_pauzaposleraskladki (bool val)
    { m_mem.setMBit(523, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_pauzaposleraskladki to " + val.ToString());}

    public bool sets_wyhd_tp_pauzaposleraskladki ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_pauzaposleraskladki (val);
    return true;}

    public string gets_wyhd_tp_pauzaposleraskladki () { 
    return get_wyhd_tp_pauzaposleraskladki().ToString();}

    public string debug_name_wyhd_tp_pauzaposleraskladki () { 
    return "����_��_�������������������";}

public enum local_outD{
wyhd_stol_abs,
wyhd_tjen1_pit,
wyhd_stol_otn_wniz,
wyhd_stol_otn_wwerh,
wyhd_laz_pit1,
wyhd_pitchil1,
wyhd_pitchil2,
wyhd_pitmps,
wyhd_pitrec,
wyhd_kv1,
wyhd_kv2,
wyhd_kje9,
wyhd_kje10,
wyhd_karpraw_abs,
wyhd_karlew_abs,
wyhd_dozpraw_wper,
wyhd_dozlew_wper,
wyhd_dozpraw_nazad,
wyhd_dozlew_nazad,
wyhd_stol_peresch_t,
wyhd_barlew_wper_d,
wyhd_barpraw_wper_d,
wyhd_barlew_nazad,
wyhd_barpraw_nazad,
wyhd_tolklew_wper_d,
wyhd_tolkpraw_wper_d,
wyhd_tolklew_nazad,
wyhd_tolkpraw_nazad,
wyhd_karpraw_otn_wper_d,
wyhd_karpraw_otn_nazad,
wyhd_karlew_otn_wper_d,
wyhd_karlew_otn_nazad,
wyhd_klbarlew,
wyhd_klbarpraw,
wyhd_nasotkgaza,
wyhd_tp_sloj_rab1,
wyhd_tp_process,
wyhd_laz_pit2,
wyhd_tp_sloj_rab2,
wyhd_tp_sloj_rab3,
wyhd_blokirowki,
wyhd_tp_pauza,
wyhd_klnapgaza,
wyhd_tp_pauzaposleraskladki,
};

public gTags[] group_outD = {
gTags.wyhd_stol_abs,
gTags.wyhd_tjen1_pit,
gTags.wyhd_stol_otn_wniz,
gTags.wyhd_stol_otn_wwerh,
gTags.wyhd_laz_pit1,
gTags.wyhd_pitchil1,
gTags.wyhd_pitchil2,
gTags.wyhd_pitmps,
gTags.wyhd_pitrec,
gTags.wyhd_kv1,
gTags.wyhd_kv2,
gTags.wyhd_kje9,
gTags.wyhd_kje10,
gTags.wyhd_karpraw_abs,
gTags.wyhd_karlew_abs,
gTags.wyhd_dozpraw_wper,
gTags.wyhd_dozlew_wper,
gTags.wyhd_dozpraw_nazad,
gTags.wyhd_dozlew_nazad,
gTags.wyhd_stol_peresch_t,
gTags.wyhd_barlew_wper_d,
gTags.wyhd_barpraw_wper_d,
gTags.wyhd_barlew_nazad,
gTags.wyhd_barpraw_nazad,
gTags.wyhd_tolklew_wper_d,
gTags.wyhd_tolkpraw_wper_d,
gTags.wyhd_tolklew_nazad,
gTags.wyhd_tolkpraw_nazad,
gTags.wyhd_karpraw_otn_wper_d,
gTags.wyhd_karpraw_otn_nazad,
gTags.wyhd_karlew_otn_wper_d,
gTags.wyhd_karlew_otn_nazad,
gTags.wyhd_klbarlew,
gTags.wyhd_klbarpraw,
gTags.wyhd_nasotkgaza,
gTags.wyhd_tp_sloj_rab1,
gTags.wyhd_tp_process,
gTags.wyhd_laz_pit2,
gTags.wyhd_tp_sloj_rab2,
gTags.wyhd_tp_sloj_rab3,
gTags.wyhd_blokirowki,
gTags.wyhd_tp_pauza,
gTags.wyhd_klnapgaza,
gTags.wyhd_tp_pauzaposleraskladki,
};

//-----------------------------------------------------------------------------
//tags/com.xml
//-----------------------------------------------------------------------------
// ���_����_��� (��������/����),   Bool, %M518.4   reg = M  width = Bit
    public bool get_kom_stol_abs ()
    { return (bool) m_mem.getMBit(518, 4); }

    public void set_kom_stol_abs (bool val)
    { m_mem.setMBit(518, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_abs to " + val.ToString());}

    public bool sets_kom_stol_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_abs (val);
    return true;}

    public string gets_kom_stol_abs () { 
    return get_kom_stol_abs().ToString();}

    public string debug_name_kom_stol_abs () { 
    return "���_����_���";}

// ���_��_���� (�����������/���������������������),   Bool, %M518.7   reg = M  width = Bit
    public bool get_kom_tp_prer ()
    { return (bool) m_mem.getMBit(518, 7); }

    public void set_kom_tp_prer (bool val)
    { m_mem.setMBit(518, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_prer to " + val.ToString());}

    public bool sets_kom_tp_prer ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_prer (val);
    return true;}

    public string gets_kom_tp_prer () { 
    return get_kom_tp_prer().ToString();}

    public string debug_name_kom_tp_prer () { 
    return "���_��_����";}

// ���_����_���� (�����/����),   Bool, %M519.2   reg = M  width = Bit
    public bool get_kom_stol_stop ()
    { return (bool) m_mem.getMBit(519, 2); }

    public void set_kom_stol_stop (bool val)
    { m_mem.setMBit(519, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_stop to " + val.ToString());}

    public bool sets_kom_stol_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_stop (val);
    return true;}

    public string gets_kom_stol_stop () { 
    return get_kom_stol_stop().ToString();}

    public string debug_name_kom_stol_stop () { 
    return "���_����_����";}

// ���_����_������� (����������������/����),   Bool, %M521.0   reg = M  width = Bit
    public bool get_kom_stol_ustnulq ()
    { return (bool) m_mem.getMBit(521, 0); }

    public void set_kom_stol_ustnulq (bool val)
    { m_mem.setMBit(521, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_ustnulq to " + val.ToString());}

    public bool sets_kom_stol_ustnulq ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_ustnulq (val);
    return true;}

    public string gets_kom_stol_ustnulq () { 
    return get_kom_stol_ustnulq().ToString();}

    public string debug_name_kom_stol_ustnulq () { 
    return "���_����_�������";}

// ���_����_���_���� (�����/����),   Bool, %M521.2   reg = M  width = Bit
    public bool get_kom_stol_otn_wniz ()
    { return (bool) m_mem.getMBit(521, 2); }

    public void set_kom_stol_otn_wniz (bool val)
    { m_mem.setMBit(521, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_otn_wniz to " + val.ToString());}

    public bool sets_kom_stol_otn_wniz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_otn_wniz (val);
    return true;}

    public string gets_kom_stol_otn_wniz () { 
    return get_kom_stol_otn_wniz().ToString();}

    public string debug_name_kom_stol_otn_wniz () { 
    return "���_����_���_����";}

// ���_����_���_����� (������/����),   Bool, %M521.3   reg = M  width = Bit
    public bool get_kom_stol_otn_wwerh ()
    { return (bool) m_mem.getMBit(521, 3); }

    public void set_kom_stol_otn_wwerh (bool val)
    { m_mem.setMBit(521, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_otn_wwerh to " + val.ToString());}

    public bool sets_kom_stol_otn_wwerh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_otn_wwerh (val);
    return true;}

    public string gets_kom_stol_otn_wwerh () { 
    return get_kom_stol_otn_wwerh().ToString();}

    public string debug_name_kom_stol_otn_wwerh () { 
    return "���_����_���_�����";}

// ���_����_��������������� (�����������������/����),   Bool, %M522.7   reg = M  width = Bit
    public bool get_kom_stol_obnulit_linejku ()
    { return (bool) m_mem.getMBit(522, 7); }

    public void set_kom_stol_obnulit_linejku (bool val)
    { m_mem.setMBit(522, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_obnulit_linejku to " + val.ToString());}

    public bool sets_kom_stol_obnulit_linejku ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_obnulit_linejku (val);
    return true;}

    public string gets_kom_stol_obnulit_linejku () { 
    return get_kom_stol_obnulit_linejku().ToString();}

    public string debug_name_kom_stol_obnulit_linejku () { 
    return "���_����_���������������";}

// ���_���1 (����1/�����������),   Bool, %M524.3   reg = M  width = Bit
    public bool get_kom_tjen1 ()
    { return (bool) m_mem.getMBit(524, 3); }

    public void set_kom_tjen1 (bool val)
    { m_mem.setMBit(524, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tjen1 to " + val.ToString());}

    public bool sets_kom_tjen1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tjen1 (val);
    return true;}

    public string gets_kom_tjen1 () { 
    return get_kom_tjen1().ToString();}

    public string debug_name_kom_tjen1 () { 
    return "���_���1";}

// ���_��_������� (��������/���������������������),   Bool, %M521.4   reg = M  width = Bit
    public bool get_kom_tp_process ()
    { return (bool) m_mem.getMBit(521, 4); }

    public void set_kom_tp_process (bool val)
    { m_mem.setMBit(521, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_process to " + val.ToString());}

    public bool sets_kom_tp_process ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_process (val);
    return true;}

    public string gets_kom_tp_process () { 
    return get_kom_tp_process().ToString();}

    public string debug_name_kom_tp_process () { 
    return "���_��_�������";}

// ���_����_�������� (���������/����),   Bool, %M526.1   reg = M  width = Bit
    public bool get_kom_stol_peresch_t ()
    { return (bool) m_mem.getMBit(526, 1); }

    public void set_kom_stol_peresch_t (bool val)
    { m_mem.setMBit(526, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_peresch_t to " + val.ToString());}

    public bool sets_kom_stol_peresch_t ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_peresch_t (val);
    return true;}

    public string gets_kom_stol_peresch_t () { 
    return get_kom_stol_peresch_t().ToString();}

    public string debug_name_kom_stol_peresch_t () { 
    return "���_����_��������";}

// ���_���_���1 (��������������1/������),   Bool, %M526.2   reg = M  width = Bit
    public bool get_kom_laz_pit1 ()
    { return (bool) m_mem.getMBit(526, 2); }

    public void set_kom_laz_pit1 (bool val)
    { m_mem.setMBit(526, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_pit1 to " + val.ToString());}

    public bool sets_kom_laz_pit1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_pit1 (val);
    return true;}

    public string gets_kom_laz_pit1 () { 
    return get_kom_laz_pit1().ToString();}

    public string debug_name_kom_laz_pit1 () { 
    return "���_���_���1";}

// ���_���_���1 (������������1/������),   Bool, %M526.3   reg = M  width = Bit
    public bool get_kom_laz_got1 ()
    { return (bool) m_mem.getMBit(526, 3); }

    public void set_kom_laz_got1 (bool val)
    { m_mem.setMBit(526, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_got1 to " + val.ToString());}

    public bool sets_kom_laz_got1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_got1 (val);
    return true;}

    public string gets_kom_laz_got1 () { 
    return get_kom_laz_got1().ToString();}

    public string debug_name_kom_laz_got1 () { 
    return "���_���_���1";}

// ���_������1 (���������������1/�������),   Bool, %M527.7   reg = M  width = Bit
    public bool get_kom_pitchil1 ()
    { return (bool) m_mem.getMBit(527, 7); }

    public void set_kom_pitchil1 (bool val)
    { m_mem.setMBit(527, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitchil1 to " + val.ToString());}

    public bool sets_kom_pitchil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitchil1 (val);
    return true;}

    public string gets_kom_pitchil1 () { 
    return get_kom_pitchil1().ToString();}

    public string debug_name_kom_pitchil1 () { 
    return "���_������1";}

// ���_������2 (���������������2/�������),   Bool, %M528.0   reg = M  width = Bit
    public bool get_kom_pitchil2 ()
    { return (bool) m_mem.getMBit(528, 0); }

    public void set_kom_pitchil2 (bool val)
    { m_mem.setMBit(528, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitchil2 to " + val.ToString());}

    public bool sets_kom_pitchil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitchil2 (val);
    return true;}

    public string gets_kom_pitchil2 () { 
    return get_kom_pitchil2().ToString();}

    public string debug_name_kom_pitchil2 () { 
    return "���_������2";}

// ���_������ (������-�������/������������),   Bool, %M528.3   reg = M  width = Bit
    public bool get_kom_pitrec ()
    { return (bool) m_mem.getMBit(528, 3); }

    public void set_kom_pitrec (bool val)
    { m_mem.setMBit(528, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitrec to " + val.ToString());}

    public bool sets_kom_pitrec ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitrec (val);
    return true;}

    public string gets_kom_pitrec () { 
    return get_kom_pitrec().ToString();}

    public string debug_name_kom_pitrec () { 
    return "���_������";}

// ���_������ (�����������/�������),   Bool, %M528.4   reg = M  width = Bit
    public bool get_kom_pitmps ()
    { return (bool) m_mem.getMBit(528, 4); }

    public void set_kom_pitmps (bool val)
    { m_mem.setMBit(528, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitmps to " + val.ToString());}

    public bool sets_kom_pitmps ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitmps (val);
    return true;}

    public string gets_kom_pitmps () { 
    return get_kom_pitmps().ToString();}

    public string debug_name_kom_pitmps () { 
    return "���_������";}

// ���_������_���_����� (��������������-������/�������),   Bool, %M529.2   reg = M  width = Bit
    public bool get_kom_karlew_otn_wper_d ()
    { return (bool) m_mem.getMBit(529, 2); }

    public void set_kom_karlew_otn_wper_d (bool val)
    { m_mem.setMBit(529, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_otn_wper_d to " + val.ToString());}

    public bool sets_kom_karlew_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_otn_wper_d (val);
    return true;}

    public string gets_kom_karlew_otn_wper_d () { 
    return get_kom_karlew_otn_wper_d().ToString();}

    public string debug_name_kom_karlew_otn_wper_d () { 
    return "���_������_���_�����";}

// ���_������_���_����� (��������������-������/�������),   Bool, %M529.3   reg = M  width = Bit
    public bool get_kom_karlew_otn_nazad ()
    { return (bool) m_mem.getMBit(529, 3); }

    public void set_kom_karlew_otn_nazad (bool val)
    { m_mem.setMBit(529, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_otn_nazad to " + val.ToString());}

    public bool sets_kom_karlew_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_otn_nazad (val);
    return true;}

    public string gets_kom_karlew_otn_nazad () { 
    return get_kom_karlew_otn_nazad().ToString();}

    public string debug_name_kom_karlew_otn_nazad () { 
    return "���_������_���_�����";}

// ���_�������_���_����� (���������������-������/�������),   Bool, %M529.6   reg = M  width = Bit
    public bool get_kom_karpraw_otn_wper_d ()
    { return (bool) m_mem.getMBit(529, 6); }

    public void set_kom_karpraw_otn_wper_d (bool val)
    { m_mem.setMBit(529, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_otn_wper_d to " + val.ToString());}

    public bool sets_kom_karpraw_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_otn_wper_d (val);
    return true;}

    public string gets_kom_karpraw_otn_wper_d () { 
    return get_kom_karpraw_otn_wper_d().ToString();}

    public string debug_name_kom_karpraw_otn_wper_d () { 
    return "���_�������_���_�����";}

// ���_�������_���_����� (���������������-������/�������),   Bool, %M529.7   reg = M  width = Bit
    public bool get_kom_karpraw_otn_nazad ()
    { return (bool) m_mem.getMBit(529, 7); }

    public void set_kom_karpraw_otn_nazad (bool val)
    { m_mem.setMBit(529, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_otn_nazad to " + val.ToString());}

    public bool sets_kom_karpraw_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_otn_nazad (val);
    return true;}

    public string gets_kom_karpraw_otn_nazad () { 
    return get_kom_karpraw_otn_nazad().ToString();}

    public string debug_name_kom_karpraw_otn_nazad () { 
    return "���_�������_���_�����";}

// ���_�������_����� (���������������-������/��������),   Bool, %M531.4   reg = M  width = Bit
    public bool get_kom_barpraw_wper_d ()
    { return (bool) m_mem.getMBit(531, 4); }

    public void set_kom_barpraw_wper_d (bool val)
    { m_mem.setMBit(531, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barpraw_wper_d to " + val.ToString());}

    public bool sets_kom_barpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barpraw_wper_d (val);
    return true;}

    public string gets_kom_barpraw_wper_d () { 
    return get_kom_barpraw_wper_d().ToString();}

    public string debug_name_kom_barpraw_wper_d () { 
    return "���_�������_�����";}

// ���_�������_����� (���������������-������/��������),   Bool, %M531.5   reg = M  width = Bit
    public bool get_kom_barpraw_nazad ()
    { return (bool) m_mem.getMBit(531, 5); }

    public void set_kom_barpraw_nazad (bool val)
    { m_mem.setMBit(531, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barpraw_nazad to " + val.ToString());}

    public bool sets_kom_barpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barpraw_nazad (val);
    return true;}

    public string gets_kom_barpraw_nazad () { 
    return get_kom_barpraw_nazad().ToString();}

    public string debug_name_kom_barpraw_nazad () { 
    return "���_�������_�����";}

// ���_������_����� (��������������-������/��������),   Bool, %M532.0   reg = M  width = Bit
    public bool get_kom_barlew_wper_d ()
    { return (bool) m_mem.getMBit(532, 0); }

    public void set_kom_barlew_wper_d (bool val)
    { m_mem.setMBit(532, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barlew_wper_d to " + val.ToString());}

    public bool sets_kom_barlew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barlew_wper_d (val);
    return true;}

    public string gets_kom_barlew_wper_d () { 
    return get_kom_barlew_wper_d().ToString();}

    public string debug_name_kom_barlew_wper_d () { 
    return "���_������_�����";}

// ���_������_����� (��������������-������/��������),   Bool, %M532.1   reg = M  width = Bit
    public bool get_kom_barlew_nazad ()
    { return (bool) m_mem.getMBit(532, 1); }

    public void set_kom_barlew_nazad (bool val)
    { m_mem.setMBit(532, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barlew_nazad to " + val.ToString());}

    public bool sets_kom_barlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barlew_nazad (val);
    return true;}

    public string gets_kom_barlew_nazad () { 
    return get_kom_barlew_nazad().ToString();}

    public string debug_name_kom_barlew_nazad () { 
    return "���_������_�����";}

// ���_������_���� (�������������-������/��������),   Bool, %M532.4   reg = M  width = Bit
    public bool get_kom_dozlew_wper ()
    { return (bool) m_mem.getMBit(532, 4); }

    public void set_kom_dozlew_wper (bool val)
    { m_mem.setMBit(532, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozlew_wper to " + val.ToString());}

    public bool sets_kom_dozlew_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozlew_wper (val);
    return true;}

    public string gets_kom_dozlew_wper () { 
    return get_kom_dozlew_wper().ToString();}

    public string debug_name_kom_dozlew_wper () { 
    return "���_������_����";}

// ���_�������_���� (��������������-������/��������),   Bool, %M532.7   reg = M  width = Bit
    public bool get_kom_dozpraw_wper ()
    { return (bool) m_mem.getMBit(532, 7); }

    public void set_kom_dozpraw_wper (bool val)
    { m_mem.setMBit(532, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozpraw_wper to " + val.ToString());}

    public bool sets_kom_dozpraw_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozpraw_wper (val);
    return true;}

    public string gets_kom_dozpraw_wper () { 
    return get_kom_dozpraw_wper().ToString();}

    public string debug_name_kom_dozpraw_wper () { 
    return "���_�������_����";}

// ���_�������_����� (����������������-������/���������),   Bool, %M533.2   reg = M  width = Bit
    public bool get_kom_tolklew_wper_d ()
    { return (bool) m_mem.getMBit(533, 2); }

    public void set_kom_tolklew_wper_d (bool val)
    { m_mem.setMBit(533, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolklew_wper_d to " + val.ToString());}

    public bool sets_kom_tolklew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolklew_wper_d (val);
    return true;}

    public string gets_kom_tolklew_wper_d () { 
    return get_kom_tolklew_wper_d().ToString();}

    public string debug_name_kom_tolklew_wper_d () { 
    return "���_�������_�����";}

// ���_�������_����� (����������������-������/���������),   Bool, %M533.3   reg = M  width = Bit
    public bool get_kom_tolklew_nazad ()
    { return (bool) m_mem.getMBit(533, 3); }

    public void set_kom_tolklew_nazad (bool val)
    { m_mem.setMBit(533, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolklew_nazad to " + val.ToString());}

    public bool sets_kom_tolklew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolklew_nazad (val);
    return true;}

    public string gets_kom_tolklew_nazad () { 
    return get_kom_tolklew_nazad().ToString();}

    public string debug_name_kom_tolklew_nazad () { 
    return "���_�������_�����";}

// ���_��������_����� (�����������������-������/���������),   Bool, %M533.5   reg = M  width = Bit
    public bool get_kom_tolkpraw_wper_d ()
    { return (bool) m_mem.getMBit(533, 5); }

    public void set_kom_tolkpraw_wper_d (bool val)
    { m_mem.setMBit(533, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkpraw_wper_d to " + val.ToString());}

    public bool sets_kom_tolkpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkpraw_wper_d (val);
    return true;}

    public string gets_kom_tolkpraw_wper_d () { 
    return get_kom_tolkpraw_wper_d().ToString();}

    public string debug_name_kom_tolkpraw_wper_d () { 
    return "���_��������_�����";}

// ���_��������_����� (�����������������-������/���������),   Bool, %M533.6   reg = M  width = Bit
    public bool get_kom_tolkpraw_nazad ()
    { return (bool) m_mem.getMBit(533, 6); }

    public void set_kom_tolkpraw_nazad (bool val)
    { m_mem.setMBit(533, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkpraw_nazad to " + val.ToString());}

    public bool sets_kom_tolkpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkpraw_nazad (val);
    return true;}

    public string gets_kom_tolkpraw_nazad () { 
    return get_kom_tolkpraw_nazad().ToString();}

    public string debug_name_kom_tolkpraw_nazad () { 
    return "���_��������_�����";}

// ���_������_����� (�������������-������/��������),   Bool, %M533.0   reg = M  width = Bit
    public bool get_kom_dozlew_nazad ()
    { return (bool) m_mem.getMBit(533, 0); }

    public void set_kom_dozlew_nazad (bool val)
    { m_mem.setMBit(533, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozlew_nazad to " + val.ToString());}

    public bool sets_kom_dozlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozlew_nazad (val);
    return true;}

    public string gets_kom_dozlew_nazad () { 
    return get_kom_dozlew_nazad().ToString();}

    public string debug_name_kom_dozlew_nazad () { 
    return "���_������_�����";}

// ���_�������_����� (��������������-������/��������),   Bool, %M533.1   reg = M  width = Bit
    public bool get_kom_dozpraw_nazad ()
    { return (bool) m_mem.getMBit(533, 1); }

    public void set_kom_dozpraw_nazad (bool val)
    { m_mem.setMBit(533, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozpraw_nazad to " + val.ToString());}

    public bool sets_kom_dozpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozpraw_nazad (val);
    return true;}

    public string gets_kom_dozpraw_nazad () { 
    return get_kom_dozpraw_nazad().ToString();}

    public string debug_name_kom_dozpraw_nazad () { 
    return "���_�������_�����";}

// ���_��9_���_����1 (���9���������������1/������),   Bool, %M533.4   reg = M  width = Bit
    public bool get_kom_kje9_ohl_skan1 ()
    { return (bool) m_mem.getMBit(533, 4); }

    public void set_kom_kje9_ohl_skan1 (bool val)
    { m_mem.setMBit(533, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kje9_ohl_skan1 to " + val.ToString());}

    public bool sets_kom_kje9_ohl_skan1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kje9_ohl_skan1 (val);
    return true;}

    public string gets_kom_kje9_ohl_skan1 () { 
    return get_kom_kje9_ohl_skan1().ToString();}

    public string debug_name_kom_kje9_ohl_skan1 () { 
    return "���_��9_���_����1";}

// ���_��10_���_����2 (���10���������������2/������),   Bool, %M533.7   reg = M  width = Bit
    public bool get_kom_kje10_ohl_skan2 ()
    { return (bool) m_mem.getMBit(533, 7); }

    public void set_kom_kje10_ohl_skan2 (bool val)
    { m_mem.setMBit(533, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kje10_ohl_skan2 to " + val.ToString());}

    public bool sets_kom_kje10_ohl_skan2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kje10_ohl_skan2 (val);
    return true;}

    public string gets_kom_kje10_ohl_skan2 () { 
    return get_kom_kje10_ohl_skan2().ToString();}

    public string debug_name_kom_kje10_ohl_skan2 () { 
    return "���_��10_���_����2";}

// ���_��1 (���1/������������),   Bool, %M534.0   reg = M  width = Bit
    public bool get_kom_kv1 ()
    { return (bool) m_mem.getMBit(534, 0); }

    public void set_kom_kv1 (bool val)
    { m_mem.setMBit(534, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kv1 to " + val.ToString());}

    public bool sets_kom_kv1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kv1 (val);
    return true;}

    public string gets_kom_kv1 () { 
    return get_kom_kv1().ToString();}

    public string debug_name_kom_kv1 () { 
    return "���_��1";}

// ���_��2 (���2/������������),   Bool, %M534.1   reg = M  width = Bit
    public bool get_kom_kv2 ()
    { return (bool) m_mem.getMBit(534, 1); }

    public void set_kom_kv2 (bool val)
    { m_mem.setMBit(534, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kv2 to " + val.ToString());}

    public bool sets_kom_kv2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kv2 (val);
    return true;}

    public string gets_kom_kv2 () { 
    return get_kom_kv2().ToString();}

    public string debug_name_kom_kv2 () { 
    return "���_��2";}

// ���_�������� (����������������������/��������),   Bool, %M534.2   reg = M  width = Bit
    public bool get_kom_klbarlew ()
    { return (bool) m_mem.getMBit(534, 2); }

    public void set_kom_klbarlew (bool val)
    { m_mem.setMBit(534, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klbarlew to " + val.ToString());}

    public bool sets_kom_klbarlew ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klbarlew (val);
    return true;}

    public string gets_kom_klbarlew () { 
    return get_kom_klbarlew().ToString();}

    public string debug_name_kom_klbarlew () { 
    return "���_��������";}

// ���_��������� (�����������������������/��������),   Bool, %M534.3   reg = M  width = Bit
    public bool get_kom_klbarpraw ()
    { return (bool) m_mem.getMBit(534, 3); }

    public void set_kom_klbarpraw (bool val)
    { m_mem.setMBit(534, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klbarpraw to " + val.ToString());}

    public bool sets_kom_klbarpraw ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klbarpraw (val);
    return true;}

    public string gets_kom_klbarpraw () { 
    return get_kom_klbarpraw().ToString();}

    public string debug_name_kom_klbarpraw () { 
    return "���_���������";}

// ���_���������� (������/��������),   Bool, %M519.1   reg = M  width = Bit
    public bool get_kom_nasotkgaza ()
    { return (bool) m_mem.getMBit(519, 1); }

    public void set_kom_nasotkgaza (bool val)
    { m_mem.setMBit(519, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_nasotkgaza to " + val.ToString());}

    public bool sets_kom_nasotkgaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_nasotkgaza (val);
    return true;}

    public string gets_kom_nasotkgaza () { 
    return get_kom_nasotkgaza().ToString();}

    public string debug_name_kom_nasotkgaza () { 
    return "���_����������";}

// ���_������_���� (��������������-�����/��������),   Bool, %M532.2   reg = M  width = Bit
    public bool get_kom_barlew_stop ()
    { return (bool) m_mem.getMBit(532, 2); }

    public void set_kom_barlew_stop (bool val)
    { m_mem.setMBit(532, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barlew_stop to " + val.ToString());}

    public bool sets_kom_barlew_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barlew_stop (val);
    return true;}

    public string gets_kom_barlew_stop () { 
    return get_kom_barlew_stop().ToString();}

    public string debug_name_kom_barlew_stop () { 
    return "���_������_����";}

// ���_�������_���� (���������������-�����/��������),   Bool, %M531.6   reg = M  width = Bit
    public bool get_kom_barpraw_stop ()
    { return (bool) m_mem.getMBit(531, 6); }

    public void set_kom_barpraw_stop (bool val)
    { m_mem.setMBit(531, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barpraw_stop to " + val.ToString());}

    public bool sets_kom_barpraw_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barpraw_stop (val);
    return true;}

    public string gets_kom_barpraw_stop () { 
    return get_kom_barpraw_stop().ToString();}

    public string debug_name_kom_barpraw_stop () { 
    return "���_�������_����";}

// ���_������_���� (�������������-�����/��������),   Bool, %M535.0   reg = M  width = Bit
    public bool get_kom_dozlew_stop ()
    { return (bool) m_mem.getMBit(535, 0); }

    public void set_kom_dozlew_stop (bool val)
    { m_mem.setMBit(535, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozlew_stop to " + val.ToString());}

    public bool sets_kom_dozlew_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozlew_stop (val);
    return true;}

    public string gets_kom_dozlew_stop () { 
    return get_kom_dozlew_stop().ToString();}

    public string debug_name_kom_dozlew_stop () { 
    return "���_������_����";}

// ���_�������_���� (��������������-�����/��������),   Bool, %M535.1   reg = M  width = Bit
    public bool get_kom_dozpraw_stop ()
    { return (bool) m_mem.getMBit(535, 1); }

    public void set_kom_dozpraw_stop (bool val)
    { m_mem.setMBit(535, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozpraw_stop to " + val.ToString());}

    public bool sets_kom_dozpraw_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozpraw_stop (val);
    return true;}

    public string gets_kom_dozpraw_stop () { 
    return get_kom_dozpraw_stop().ToString();}

    public string debug_name_kom_dozpraw_stop () { 
    return "���_�������_����";}

// ���_������_���� (��������������-�����/�������),   Bool, %M529.5   reg = M  width = Bit
    public bool get_kom_karlew_stop ()
    { return (bool) m_mem.getMBit(529, 5); }

    public void set_kom_karlew_stop (bool val)
    { m_mem.setMBit(529, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_stop to " + val.ToString());}

    public bool sets_kom_karlew_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_stop (val);
    return true;}

    public string gets_kom_karlew_stop () { 
    return get_kom_karlew_stop().ToString();}

    public string debug_name_kom_karlew_stop () { 
    return "���_������_����";}

// ���_�������_���� (���������������-�����/�������),   Bool, %M531.3   reg = M  width = Bit
    public bool get_kom_karpraw_stop ()
    { return (bool) m_mem.getMBit(531, 3); }

    public void set_kom_karpraw_stop (bool val)
    { m_mem.setMBit(531, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_stop to " + val.ToString());}

    public bool sets_kom_karpraw_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_stop (val);
    return true;}

    public string gets_kom_karpraw_stop () { 
    return get_kom_karpraw_stop().ToString();}

    public string debug_name_kom_karpraw_stop () { 
    return "���_�������_����";}

// ���_���_���2 (������������2/������),   Bool, %M526.4   reg = M  width = Bit
    public bool get_kom_laz_got2 ()
    { return (bool) m_mem.getMBit(526, 4); }

    public void set_kom_laz_got2 (bool val)
    { m_mem.setMBit(526, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_got2 to " + val.ToString());}

    public bool sets_kom_laz_got2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_got2 (val);
    return true;}

    public string gets_kom_laz_got2 () { 
    return get_kom_laz_got2().ToString();}

    public string debug_name_kom_laz_got2 () { 
    return "���_���_���2";}

// ���_���_���2 (��������������2/������),   Bool, %M526.5   reg = M  width = Bit
    public bool get_kom_laz_pit2 ()
    { return (bool) m_mem.getMBit(526, 5); }

    public void set_kom_laz_pit2 (bool val)
    { m_mem.setMBit(526, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_pit2 to " + val.ToString());}

    public bool sets_kom_laz_pit2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_pit2 (val);
    return true;}

    public string gets_kom_laz_pit2 () { 
    return get_kom_laz_pit2().ToString();}

    public string debug_name_kom_laz_pit2 () { 
    return "���_���_���2";}

// ���_����������� (������������/������),   Bool, %M526.6   reg = M  width = Bit
    public bool get_kom_sbrosawarii ()
    { return (bool) m_mem.getMBit(526, 6); }

    public void set_kom_sbrosawarii (bool val)
    { m_mem.setMBit(526, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_sbrosawarii to " + val.ToString());}

    public bool sets_kom_sbrosawarii ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_sbrosawarii (val);
    return true;}

    public string gets_kom_sbrosawarii () { 
    return get_kom_sbrosawarii().ToString();}

    public string debug_name_kom_sbrosawarii () { 
    return "���_�����������";}

// ���_���������� (�����������/������),   Bool, %M526.7   reg = M  width = Bit
    public bool get_kom_blokirowki ()
    { return (bool) m_mem.getMBit(526, 7); }

    public void set_kom_blokirowki (bool val)
    { m_mem.setMBit(526, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_blokirowki to " + val.ToString());}

    public bool sets_kom_blokirowki ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_blokirowki (val);
    return true;}

    public string gets_kom_blokirowki () { 
    return get_kom_blokirowki().ToString();}

    public string debug_name_kom_blokirowki () { 
    return "���_����������";}

// ���_��_����� (������/���������������������),   Bool, %M521.6   reg = M  width = Bit
    public bool get_kom_tp_pauza ()
    { return (bool) m_mem.getMBit(521, 6); }

    public void set_kom_tp_pauza (bool val)
    { m_mem.setMBit(521, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_pauza to " + val.ToString());}

    public bool sets_kom_tp_pauza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_pauza (val);
    return true;}

    public string gets_kom_tp_pauza () { 
    return get_kom_tp_pauza().ToString();}

    public string debug_name_kom_tp_pauza () { 
    return "���_��_�����";}

// ���_��������� (�������������������/������������),   Bool, %M521.7   reg = M  width = Bit
    public bool get_kom_klnapgaza ()
    { return (bool) m_mem.getMBit(521, 7); }

    public void set_kom_klnapgaza (bool val)
    { m_mem.setMBit(521, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klnapgaza to " + val.ToString());}

    public bool sets_kom_klnapgaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klnapgaza (val);
    return true;}

    public string gets_kom_klnapgaza () { 
    return get_kom_klnapgaza().ToString();}

    public string debug_name_kom_klnapgaza () { 
    return "���_���������";}

// ���_��_���� (�����/���������������������),   Bool, %M522.5   reg = M  width = Bit
    public bool get_kom_tp_stop ()
    { return (bool) m_mem.getMBit(522, 5); }

    public void set_kom_tp_stop (bool val)
    { m_mem.setMBit(522, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_stop to " + val.ToString());}

    public bool sets_kom_tp_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_stop (val);
    return true;}

    public string gets_kom_tp_stop () { 
    return get_kom_tp_stop().ToString();}

    public string debug_name_kom_tp_stop () { 
    return "���_��_����";}

// ���_��_������������������� (��������������������/���������������������),   Bool, %M522.6   reg = M  width = Bit
    public bool get_kom_tp_pauzaposleraskladki ()
    { return (bool) m_mem.getMBit(522, 6); }

    public void set_kom_tp_pauzaposleraskladki (bool val)
    { m_mem.setMBit(522, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_pauzaposleraskladki to " + val.ToString());}

    public bool sets_kom_tp_pauzaposleraskladki ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_pauzaposleraskladki (val);
    return true;}

    public string gets_kom_tp_pauzaposleraskladki () { 
    return get_kom_tp_pauzaposleraskladki().ToString();}

    public string debug_name_kom_tp_pauzaposleraskladki () { 
    return "���_��_�������������������";}

public enum local_com{
kom_stol_abs,
kom_tp_prer,
kom_stol_stop,
kom_stol_ustnulq,
kom_stol_otn_wniz,
kom_stol_otn_wwerh,
kom_stol_obnulit_linejku,
kom_tjen1,
kom_tp_process,
kom_stol_peresch_t,
kom_laz_pit1,
kom_laz_got1,
kom_pitchil1,
kom_pitchil2,
kom_pitrec,
kom_pitmps,
kom_karlew_otn_wper_d,
kom_karlew_otn_nazad,
kom_karpraw_otn_wper_d,
kom_karpraw_otn_nazad,
kom_barpraw_wper_d,
kom_barpraw_nazad,
kom_barlew_wper_d,
kom_barlew_nazad,
kom_dozlew_wper,
kom_dozpraw_wper,
kom_tolklew_wper_d,
kom_tolklew_nazad,
kom_tolkpraw_wper_d,
kom_tolkpraw_nazad,
kom_dozlew_nazad,
kom_dozpraw_nazad,
kom_kje9_ohl_skan1,
kom_kje10_ohl_skan2,
kom_kv1,
kom_kv2,
kom_klbarlew,
kom_klbarpraw,
kom_nasotkgaza,
kom_barlew_stop,
kom_barpraw_stop,
kom_dozlew_stop,
kom_dozpraw_stop,
kom_karlew_stop,
kom_karpraw_stop,
kom_laz_got2,
kom_laz_pit2,
kom_sbrosawarii,
kom_blokirowki,
kom_tp_pauza,
kom_klnapgaza,
kom_tp_stop,
kom_tp_pauzaposleraskladki,
};

public gTags[] group_com = {
gTags.kom_stol_abs,
gTags.kom_tp_prer,
gTags.kom_stol_stop,
gTags.kom_stol_ustnulq,
gTags.kom_stol_otn_wniz,
gTags.kom_stol_otn_wwerh,
gTags.kom_stol_obnulit_linejku,
gTags.kom_tjen1,
gTags.kom_tp_process,
gTags.kom_stol_peresch_t,
gTags.kom_laz_pit1,
gTags.kom_laz_got1,
gTags.kom_pitchil1,
gTags.kom_pitchil2,
gTags.kom_pitrec,
gTags.kom_pitmps,
gTags.kom_karlew_otn_wper_d,
gTags.kom_karlew_otn_nazad,
gTags.kom_karpraw_otn_wper_d,
gTags.kom_karpraw_otn_nazad,
gTags.kom_barpraw_wper_d,
gTags.kom_barpraw_nazad,
gTags.kom_barlew_wper_d,
gTags.kom_barlew_nazad,
gTags.kom_dozlew_wper,
gTags.kom_dozpraw_wper,
gTags.kom_tolklew_wper_d,
gTags.kom_tolklew_nazad,
gTags.kom_tolkpraw_wper_d,
gTags.kom_tolkpraw_nazad,
gTags.kom_dozlew_nazad,
gTags.kom_dozpraw_nazad,
gTags.kom_kje9_ohl_skan1,
gTags.kom_kje10_ohl_skan2,
gTags.kom_kv1,
gTags.kom_kv2,
gTags.kom_klbarlew,
gTags.kom_klbarpraw,
gTags.kom_nasotkgaza,
gTags.kom_barlew_stop,
gTags.kom_barpraw_stop,
gTags.kom_dozlew_stop,
gTags.kom_dozpraw_stop,
gTags.kom_karlew_stop,
gTags.kom_karpraw_stop,
gTags.kom_laz_got2,
gTags.kom_laz_pit2,
gTags.kom_sbrosawarii,
gTags.kom_blokirowki,
gTags.kom_tp_pauza,
gTags.kom_klnapgaza,
gTags.kom_tp_stop,
gTags.kom_tp_pauzaposleraskladki,
};

//-----------------------------------------------------------------------------
//tags/usttp.xml
//-----------------------------------------------------------------------------
// �����_�������_���� (���������������-���������/���������������������),   Real, %MD94   reg = M  width = UInt32
    public float get_usttp_karpraw_skor ()
    { return (float) m_mem.getMFloat(94); }

    public void set_usttp_karpraw_skor (float val)
    { m_mem.setMFloat(94, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karpraw_skor to " + val.ToString());}

    public bool sets_usttp_karpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karpraw_skor (val);
    return true;}

    public string gets_usttp_karpraw_skor () { 
    return get_usttp_karpraw_skor().ToString();}

    public string debug_name_usttp_karpraw_skor () { 
    return "�����_�������_����";}

// �����_������_���� (��������������-����������/���������������������),   Real, %MD98   reg = M  width = UInt32
    public float get_usttp_karlew_skor ()
    { return (float) m_mem.getMFloat(98); }

    public void set_usttp_karlew_skor (float val)
    { m_mem.setMFloat(98, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karlew_skor to " + val.ToString());}

    public bool sets_usttp_karlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karlew_skor (val);
    return true;}

    public string gets_usttp_karlew_skor () { 
    return get_usttp_karlew_skor().ToString();}

    public string debug_name_usttp_karlew_skor () { 
    return "�����_������_����";}

// �����_��������_����� (�����������������-������/���������������������),   Real, %MD106   reg = M  width = UInt32
    public float get_usttp_tolkpraw_rasst ()
    { return (float) m_mem.getMFloat(106); }

    public void set_usttp_tolkpraw_rasst (float val)
    { m_mem.setMFloat(106, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_tolkpraw_rasst to " + val.ToString());}

    public bool sets_usttp_tolkpraw_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_tolkpraw_rasst (val);
    return true;}

    public string gets_usttp_tolkpraw_rasst () { 
    return get_usttp_tolkpraw_rasst().ToString();}

    public string debug_name_usttp_tolkpraw_rasst () { 
    return "�����_��������_�����";}

// �����_��������_���� (�����������������-��������������/���������������������),   Real, %MD110   reg = M  width = UInt32
    public float get_usttp_tolkpraw_skor ()
    { return (float) m_mem.getMFloat(110); }

    public void set_usttp_tolkpraw_skor (float val)
    { m_mem.setMFloat(110, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_tolkpraw_skor to " + val.ToString());}

    public bool sets_usttp_tolkpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_tolkpraw_skor (val);
    return true;}

    public string gets_usttp_tolkpraw_skor () { 
    return get_usttp_tolkpraw_skor().ToString();}

    public string debug_name_usttp_tolkpraw_skor () { 
    return "�����_��������_����";}

// �����_�������_�����2 (���������������-������2/���������������������),   Real, %MD118   reg = M  width = UInt32
    public float get_usttp_karpraw_rasst2 ()
    { return (float) m_mem.getMFloat(118); }

    public void set_usttp_karpraw_rasst2 (float val)
    { m_mem.setMFloat(118, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karpraw_rasst2 to " + val.ToString());}

    public bool sets_usttp_karpraw_rasst2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karpraw_rasst2 (val);
    return true;}

    public string gets_usttp_karpraw_rasst2 () { 
    return get_usttp_karpraw_rasst2().ToString();}

    public string debug_name_usttp_karpraw_rasst2 () { 
    return "�����_�������_�����2";}

// �����_�������_����� (��������������-�������/���������������������),   Real, %MD122   reg = M  width = UInt32
    public float get_usttp_dozpraw_wremq ()
    { return (float) m_mem.getMFloat(122); }

    public void set_usttp_dozpraw_wremq (float val)
    { m_mem.setMFloat(122, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_dozpraw_wremq to " + val.ToString());}

    public bool sets_usttp_dozpraw_wremq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_dozpraw_wremq (val);
    return true;}

    public string gets_usttp_dozpraw_wremq () { 
    return get_usttp_dozpraw_wremq().ToString();}

    public string debug_name_usttp_dozpraw_wremq () { 
    return "�����_�������_�����";}

// �����_�������_���� (��������������-���������/���������������������),   Real, %MD126   reg = M  width = UInt32
    public float get_usttp_dozpraw_skor ()
    { return (float) m_mem.getMFloat(126); }

    public void set_usttp_dozpraw_skor (float val)
    { m_mem.setMFloat(126, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_dozpraw_skor to " + val.ToString());}

    public bool sets_usttp_dozpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_dozpraw_skor (val);
    return true;}

    public string gets_usttp_dozpraw_skor () { 
    return get_usttp_dozpraw_skor().ToString();}

    public string debug_name_usttp_dozpraw_skor () { 
    return "�����_�������_����";}

// �����_�������_�����3 (���������������-������3/���������������������),   Real, %MD130   reg = M  width = UInt32
    public float get_usttp_karpraw_rasst3 ()
    { return (float) m_mem.getMFloat(130); }

    public void set_usttp_karpraw_rasst3 (float val)
    { m_mem.setMFloat(130, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karpraw_rasst3 to " + val.ToString());}

    public bool sets_usttp_karpraw_rasst3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karpraw_rasst3 (val);
    return true;}

    public string gets_usttp_karpraw_rasst3 () { 
    return get_usttp_karpraw_rasst3().ToString();}

    public string debug_name_usttp_karpraw_rasst3 () { 
    return "�����_�������_�����3";}

// �����_�������_�����4 (���������������-������4/���������������������),   Real, %MD134   reg = M  width = UInt32
    public float get_usttp_karpraw_rasst4 ()
    { return (float) m_mem.getMFloat(134); }

    public void set_usttp_karpraw_rasst4 (float val)
    { m_mem.setMFloat(134, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karpraw_rasst4 to " + val.ToString());}

    public bool sets_usttp_karpraw_rasst4 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karpraw_rasst4 (val);
    return true;}

    public string gets_usttp_karpraw_rasst4 () { 
    return get_usttp_karpraw_rasst4().ToString();}

    public string debug_name_usttp_karpraw_rasst4 () { 
    return "�����_�������_�����4";}

// �����_�������_���� (����������������-���������/���������������������),   Real, %MD138   reg = M  width = UInt32
    public float get_usttp_barpraw_skor ()
    { return (float) m_mem.getMFloat(138); }

    public void set_usttp_barpraw_skor (float val)
    { m_mem.setMFloat(138, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barpraw_skor to " + val.ToString());}

    public bool sets_usttp_barpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barpraw_skor (val);
    return true;}

    public string gets_usttp_barpraw_skor () { 
    return get_usttp_barpraw_skor().ToString();}

    public string debug_name_usttp_barpraw_skor () { 
    return "�����_�������_����";}

// �����_�������_�����5 (���������������-������5/���������������������),   Real, %MD142   reg = M  width = UInt32
    public float get_usttp_karpraw_rasst5 ()
    { return (float) m_mem.getMFloat(142); }

    public void set_usttp_karpraw_rasst5 (float val)
    { m_mem.setMFloat(142, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karpraw_rasst5 to " + val.ToString());}

    public bool sets_usttp_karpraw_rasst5 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karpraw_rasst5 (val);
    return true;}

    public string gets_usttp_karpraw_rasst5 () { 
    return get_usttp_karpraw_rasst5().ToString();}

    public string debug_name_usttp_karpraw_rasst5 () { 
    return "�����_�������_�����5";}

// �����_������_�����1 (��������������-������1/���������������������),   Real, %MD146   reg = M  width = UInt32
    public float get_usttp_karlew_rasst1 ()
    { return (float) m_mem.getMFloat(146); }

    public void set_usttp_karlew_rasst1 (float val)
    { m_mem.setMFloat(146, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karlew_rasst1 to " + val.ToString());}

    public bool sets_usttp_karlew_rasst1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karlew_rasst1 (val);
    return true;}

    public string gets_usttp_karlew_rasst1 () { 
    return get_usttp_karlew_rasst1().ToString();}

    public string debug_name_usttp_karlew_rasst1 () { 
    return "�����_������_�����1";}

// �����_�������_����� (����������������-������/���������������������),   Real, %MD150   reg = M  width = UInt32
    public float get_usttp_tolklew_rasst ()
    { return (float) m_mem.getMFloat(150); }

    public void set_usttp_tolklew_rasst (float val)
    { m_mem.setMFloat(150, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_tolklew_rasst to " + val.ToString());}

    public bool sets_usttp_tolklew_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_tolklew_rasst (val);
    return true;}

    public string gets_usttp_tolklew_rasst () { 
    return get_usttp_tolklew_rasst().ToString();}

    public string debug_name_usttp_tolklew_rasst () { 
    return "�����_�������_�����";}

// �����_�������_���� (����������������-��������������/���������������������),   Real, %MD154   reg = M  width = UInt32
    public float get_usttp_tolklew_skor ()
    { return (float) m_mem.getMFloat(154); }

    public void set_usttp_tolklew_skor (float val)
    { m_mem.setMFloat(154, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_tolklew_skor to " + val.ToString());}

    public bool sets_usttp_tolklew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_tolklew_skor (val);
    return true;}

    public string gets_usttp_tolklew_skor () { 
    return get_usttp_tolklew_skor().ToString();}

    public string debug_name_usttp_tolklew_skor () { 
    return "�����_�������_����";}

// �����_������_�����2 (��������������-������2/���������������������),   Real, %MD162   reg = M  width = UInt32
    public float get_usttp_karlew_rasst2 ()
    { return (float) m_mem.getMFloat(162); }

    public void set_usttp_karlew_rasst2 (float val)
    { m_mem.setMFloat(162, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karlew_rasst2 to " + val.ToString());}

    public bool sets_usttp_karlew_rasst2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karlew_rasst2 (val);
    return true;}

    public string gets_usttp_karlew_rasst2 () { 
    return get_usttp_karlew_rasst2().ToString();}

    public string debug_name_usttp_karlew_rasst2 () { 
    return "�����_������_�����2";}

// �����_������_����� (�������������-�������/���������������������),   Real, %MD166   reg = M  width = UInt32
    public float get_usttp_dozlew_wremq ()
    { return (float) m_mem.getMFloat(166); }

    public void set_usttp_dozlew_wremq (float val)
    { m_mem.setMFloat(166, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_dozlew_wremq to " + val.ToString());}

    public bool sets_usttp_dozlew_wremq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_dozlew_wremq (val);
    return true;}

    public string gets_usttp_dozlew_wremq () { 
    return get_usttp_dozlew_wremq().ToString();}

    public string debug_name_usttp_dozlew_wremq () { 
    return "�����_������_�����";}

// �����_������_���� (�������������-���������/���������������������),   Real, %MD170   reg = M  width = UInt32
    public float get_usttp_dozlew_skor ()
    { return (float) m_mem.getMFloat(170); }

    public void set_usttp_dozlew_skor (float val)
    { m_mem.setMFloat(170, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_dozlew_skor to " + val.ToString());}

    public bool sets_usttp_dozlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_dozlew_skor (val);
    return true;}

    public string gets_usttp_dozlew_skor () { 
    return get_usttp_dozlew_skor().ToString();}

    public string debug_name_usttp_dozlew_skor () { 
    return "�����_������_����";}

// �����_������_�����3 (��������������-������3/���������������������),   Real, %MD174   reg = M  width = UInt32
    public float get_usttp_karlew_rasst3 ()
    { return (float) m_mem.getMFloat(174); }

    public void set_usttp_karlew_rasst3 (float val)
    { m_mem.setMFloat(174, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karlew_rasst3 to " + val.ToString());}

    public bool sets_usttp_karlew_rasst3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karlew_rasst3 (val);
    return true;}

    public string gets_usttp_karlew_rasst3 () { 
    return get_usttp_karlew_rasst3().ToString();}

    public string debug_name_usttp_karlew_rasst3 () { 
    return "�����_������_�����3";}

// �����_������_�����4 (��������������-������4/���������������������),   Real, %MD178   reg = M  width = UInt32
    public float get_usttp_karlew_rasst4 ()
    { return (float) m_mem.getMFloat(178); }

    public void set_usttp_karlew_rasst4 (float val)
    { m_mem.setMFloat(178, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karlew_rasst4 to " + val.ToString());}

    public bool sets_usttp_karlew_rasst4 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karlew_rasst4 (val);
    return true;}

    public string gets_usttp_karlew_rasst4 () { 
    return get_usttp_karlew_rasst4().ToString();}

    public string debug_name_usttp_karlew_rasst4 () { 
    return "�����_������_�����4";}

// �����_������_���� (���������������-���������/���������������������),   Real, %MD182   reg = M  width = UInt32
    public float get_usttp_barlew_skor ()
    { return (float) m_mem.getMFloat(182); }

    public void set_usttp_barlew_skor (float val)
    { m_mem.setMFloat(182, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barlew_skor to " + val.ToString());}

    public bool sets_usttp_barlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barlew_skor (val);
    return true;}

    public string gets_usttp_barlew_skor () { 
    return get_usttp_barlew_skor().ToString();}

    public string debug_name_usttp_barlew_skor () { 
    return "�����_������_����";}

// �����_������_�����5 (��������������-������5/���������������������),   Real, %MD186   reg = M  width = UInt32
    public float get_usttp_karlew_rasst5 ()
    { return (float) m_mem.getMFloat(186); }

    public void set_usttp_karlew_rasst5 (float val)
    { m_mem.setMFloat(186, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karlew_rasst5 to " + val.ToString());}

    public bool sets_usttp_karlew_rasst5 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karlew_rasst5 (val);
    return true;}

    public string gets_usttp_karlew_rasst5 () { 
    return get_usttp_karlew_rasst5().ToString();}

    public string debug_name_usttp_karlew_rasst5 () { 
    return "�����_������_�����5";}

// �����_��������2 (������������2/���������������������),   Real, %MD190   reg = M  width = UInt32
    public float get_usttp_tolschsloq2 ()
    { return (float) m_mem.getMFloat(190); }

    public void set_usttp_tolschsloq2 (float val)
    { m_mem.setMFloat(190, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_tolschsloq2 to " + val.ToString());}

    public bool sets_usttp_tolschsloq2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_tolschsloq2 (val);
    return true;}

    public string gets_usttp_tolschsloq2 () { 
    return get_usttp_tolschsloq2().ToString();}

    public string debug_name_usttp_tolschsloq2 () { 
    return "�����_��������2";}

// �����_�����1 (������1/���������������������),   Real, %MD194   reg = M  width = UInt32
    public float get_usttp_pauza1 ()
    { return (float) m_mem.getMFloat(194); }

    public void set_usttp_pauza1 (float val)
    { m_mem.setMFloat(194, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_pauza1 to " + val.ToString());}

    public bool sets_usttp_pauza1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_pauza1 (val);
    return true;}

    public string gets_usttp_pauza1 () { 
    return get_usttp_pauza1().ToString();}

    public string debug_name_usttp_pauza1 () { 
    return "�����_�����1";}

// �����_��������1 (������������1/���������������������),   Real, %MD202   reg = M  width = UInt32
    public float get_usttp_tolschsloq1 ()
    { return (float) m_mem.getMFloat(202); }

    public void set_usttp_tolschsloq1 (float val)
    { m_mem.setMFloat(202, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_tolschsloq1 to " + val.ToString());}

    public bool sets_usttp_tolschsloq1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_tolschsloq1 (val);
    return true;}

    public string gets_usttp_tolschsloq1 () { 
    return get_usttp_tolschsloq1().ToString();}

    public string debug_name_usttp_tolschsloq1 () { 
    return "�����_��������1";}

// �����_�����2 (������2/���������������������),   Real, %MD198   reg = M  width = UInt32
    public float get_usttp_pauza2 ()
    { return (float) m_mem.getMFloat(198); }

    public void set_usttp_pauza2 (float val)
    { m_mem.setMFloat(198, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_pauza2 to " + val.ToString());}

    public bool sets_usttp_pauza2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_pauza2 (val);
    return true;}

    public string gets_usttp_pauza2 () { 
    return get_usttp_pauza2().ToString();}

    public string debug_name_usttp_pauza2 () { 
    return "�����_�����2";}

// �����_�������_�����1 (���������������-������1/���������������������),   Real, %MD102   reg = M  width = UInt32
    public float get_usttp_karpraw_rasst1 ()
    { return (float) m_mem.getMFloat(102); }

    public void set_usttp_karpraw_rasst1 (float val)
    { m_mem.setMFloat(102, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_karpraw_rasst1 to " + val.ToString());}

    public bool sets_usttp_karpraw_rasst1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_karpraw_rasst1 (val);
    return true;}

    public string gets_usttp_karpraw_rasst1 () { 
    return get_usttp_karpraw_rasst1().ToString();}

    public string debug_name_usttp_karpraw_rasst1 () { 
    return "�����_�������_�����1";}

// �����_�������_�������� (���������������-����������������������/���������������������),   Real, %MD114   reg = M  width = UInt32
    public float get_usttp_barpraw_skorrask ()
    { return (float) m_mem.getMFloat(114); }

    public void set_usttp_barpraw_skorrask (float val)
    { m_mem.setMFloat(114, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barpraw_skorrask to " + val.ToString());}

    public bool sets_usttp_barpraw_skorrask ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barpraw_skorrask (val);
    return true;}

    public string gets_usttp_barpraw_skorrask () { 
    return get_usttp_barpraw_skorrask().ToString();}

    public string debug_name_usttp_barpraw_skorrask () { 
    return "�����_�������_��������";}

// �����_�������_�������� (���������������-��������������/���������������������),   Real, %MD158   reg = M  width = UInt32
    public float get_usttp_barpraw_koorpusk ()
    { return (float) m_mem.getMFloat(158); }

    public void set_usttp_barpraw_koorpusk (float val)
    { m_mem.setMFloat(158, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barpraw_koorpusk to " + val.ToString());}

    public bool sets_usttp_barpraw_koorpusk ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barpraw_koorpusk (val);
    return true;}

    public string gets_usttp_barpraw_koorpusk () { 
    return get_usttp_barpraw_koorpusk().ToString();}

    public string debug_name_usttp_barpraw_koorpusk () { 
    return "�����_�������_��������";}

// �����_�������_�������� (���������������-�����������������/���������������������),   Real, %MD206   reg = M  width = UInt32
    public float get_usttp_barpraw_koorstop ()
    { return (float) m_mem.getMFloat(206); }

    public void set_usttp_barpraw_koorstop (float val)
    { m_mem.setMFloat(206, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barpraw_koorstop to " + val.ToString());}

    public bool sets_usttp_barpraw_koorstop ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barpraw_koorstop (val);
    return true;}

    public string gets_usttp_barpraw_koorstop () { 
    return get_usttp_barpraw_koorstop().ToString();}

    public string debug_name_usttp_barpraw_koorstop () { 
    return "�����_�������_��������";}

// �����_������_�������� (��������������-����������������������/���������������������),   Real, %MD210   reg = M  width = UInt32
    public float get_usttp_barlew_skorrask ()
    { return (float) m_mem.getMFloat(210); }

    public void set_usttp_barlew_skorrask (float val)
    { m_mem.setMFloat(210, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barlew_skorrask to " + val.ToString());}

    public bool sets_usttp_barlew_skorrask ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barlew_skorrask (val);
    return true;}

    public string gets_usttp_barlew_skorrask () { 
    return get_usttp_barlew_skorrask().ToString();}

    public string debug_name_usttp_barlew_skorrask () { 
    return "�����_������_��������";}

// �����_������_�������� (��������������-��������������/���������������������),   Real, %MD214   reg = M  width = UInt32
    public float get_usttp_barlew_koorpusk ()
    { return (float) m_mem.getMFloat(214); }

    public void set_usttp_barlew_koorpusk (float val)
    { m_mem.setMFloat(214, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barlew_koorpusk to " + val.ToString());}

    public bool sets_usttp_barlew_koorpusk ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barlew_koorpusk (val);
    return true;}

    public string gets_usttp_barlew_koorpusk () { 
    return get_usttp_barlew_koorpusk().ToString();}

    public string debug_name_usttp_barlew_koorpusk () { 
    return "�����_������_��������";}

// �����_������_�������� (��������������-�����������������/���������������������),   Real, %MD218   reg = M  width = UInt32
    public float get_usttp_barlew_koorstop ()
    { return (float) m_mem.getMFloat(218); }

    public void set_usttp_barlew_koorstop (float val)
    { m_mem.setMFloat(218, (float) val); 
      Log.Write(LogLevel.Info, "set usttp_barlew_koorstop to " + val.ToString());}

    public bool sets_usttp_barlew_koorstop ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_usttp_barlew_koorstop (val);
    return true;}

    public string gets_usttp_barlew_koorstop () { 
    return get_usttp_barlew_koorstop().ToString();}

    public string debug_name_usttp_barlew_koorstop () { 
    return "�����_������_��������";}

public enum local_usttp{
usttp_karpraw_skor,
usttp_karlew_skor,
usttp_tolkpraw_rasst,
usttp_tolkpraw_skor,
usttp_karpraw_rasst2,
usttp_dozpraw_wremq,
usttp_dozpraw_skor,
usttp_karpraw_rasst3,
usttp_karpraw_rasst4,
usttp_barpraw_skor,
usttp_karpraw_rasst5,
usttp_karlew_rasst1,
usttp_tolklew_rasst,
usttp_tolklew_skor,
usttp_karlew_rasst2,
usttp_dozlew_wremq,
usttp_dozlew_skor,
usttp_karlew_rasst3,
usttp_karlew_rasst4,
usttp_barlew_skor,
usttp_karlew_rasst5,
usttp_tolschsloq2,
usttp_pauza1,
usttp_tolschsloq1,
usttp_pauza2,
usttp_karpraw_rasst1,
usttp_barpraw_skorrask,
usttp_barpraw_koorpusk,
usttp_barpraw_koorstop,
usttp_barlew_skorrask,
usttp_barlew_koorpusk,
usttp_barlew_koorstop,
};

public gTags[] group_usttp = {
gTags.usttp_karpraw_skor,
gTags.usttp_karlew_skor,
gTags.usttp_tolkpraw_rasst,
gTags.usttp_tolkpraw_skor,
gTags.usttp_karpraw_rasst2,
gTags.usttp_dozpraw_wremq,
gTags.usttp_dozpraw_skor,
gTags.usttp_karpraw_rasst3,
gTags.usttp_karpraw_rasst4,
gTags.usttp_barpraw_skor,
gTags.usttp_karpraw_rasst5,
gTags.usttp_karlew_rasst1,
gTags.usttp_tolklew_rasst,
gTags.usttp_tolklew_skor,
gTags.usttp_karlew_rasst2,
gTags.usttp_dozlew_wremq,
gTags.usttp_dozlew_skor,
gTags.usttp_karlew_rasst3,
gTags.usttp_karlew_rasst4,
gTags.usttp_barlew_skor,
gTags.usttp_karlew_rasst5,
gTags.usttp_tolschsloq2,
gTags.usttp_pauza1,
gTags.usttp_tolschsloq1,
gTags.usttp_pauza2,
gTags.usttp_karpraw_rasst1,
gTags.usttp_barpraw_skorrask,
gTags.usttp_barpraw_koorpusk,
gTags.usttp_barpraw_koorstop,
gTags.usttp_barlew_skorrask,
gTags.usttp_barlew_koorpusk,
gTags.usttp_barlew_koorstop,
};

public enum gTags{
am_termopara1,
am_dif_datch_rash,
am_dawl_lew_fil_tr,
am_dawl_praw_fil_tr,
am_linejka,
am_tjen1_tek_moschn,
am_kar_lew_tek_poz,
am_stol_tek_poz,
am_laz1_temp1,
am_laz1_temp2,
am_laz1_temp3,
am_laz2_temp1,
am_laz2_temp2,
am_laz2_temp3,
am_datch_kisl1,
am_datch_kisl2,
am_kar_praw_tek_poz,
am_dawl_w_kamere,
am_ohl_skan1,
am_ohl_skan2,
nomer,
am_dawl_w_kamere_dubl_r,
am_oxik,
dm_stol_abs_domgot,
dm_laz1_prot1,
dm_laz1_prot2,
dm_laz1_prot3,
dm_laz2_prot1,
dm_laz2_prot2,
dm_laz2_prot3,
dm_karpraw_konc,
dm_karlew_konc,
razreshenie,
gotownost,
ind_skan1_ohl,
ind_skan2_ohl,
ind_laz1_ohl,
ind_laz2_ohl,
ind_kislorod,
ind_dawlkam,
ust_stol_abs_poz,
ust_stol_skor,
ust_stol_otn_rasst,
ust_tjen1_moschn,
ust_tjen2_moschn,
ust_tjen3_moschn,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
ust_karlew_skor,
ust_karlew_otn_rast,
ust_karlew_abs_poz,
ust_karpraw_skor,
ust_karpraw_otn_rast,
ust_karpraw_abs_poz,
ust_barpraw_skor,
ust_barlew_skor,
ust_dozlew_wremq,
ust_dozpraw_wremq,
ust_tolklew_rasst,
ust_tolkpraw_rasst,
ust_dozpraw_skor,
ust_dozlew_skor,
ust_tolklew_skor,
ust_tolkpraw_skor,
wyhd_stol_abs,
wyhd_tjen1_pit,
wyhd_stol_otn_wniz,
wyhd_stol_otn_wwerh,
wyhd_laz_pit1,
wyhd_pitchil1,
wyhd_pitchil2,
wyhd_pitmps,
wyhd_pitrec,
wyhd_kv1,
wyhd_kv2,
wyhd_kje9,
wyhd_kje10,
wyhd_karpraw_abs,
wyhd_karlew_abs,
wyhd_dozpraw_wper,
wyhd_dozlew_wper,
wyhd_dozpraw_nazad,
wyhd_dozlew_nazad,
wyhd_stol_peresch_t,
wyhd_barlew_wper_d,
wyhd_barpraw_wper_d,
wyhd_barlew_nazad,
wyhd_barpraw_nazad,
wyhd_tolklew_wper_d,
wyhd_tolkpraw_wper_d,
wyhd_tolklew_nazad,
wyhd_tolkpraw_nazad,
wyhd_karpraw_otn_wper_d,
wyhd_karpraw_otn_nazad,
wyhd_karlew_otn_wper_d,
wyhd_karlew_otn_nazad,
wyhd_klbarlew,
wyhd_klbarpraw,
wyhd_nasotkgaza,
wyhd_tp_sloj_rab1,
wyhd_tp_process,
wyhd_laz_pit2,
wyhd_tp_sloj_rab2,
wyhd_tp_sloj_rab3,
wyhd_blokirowki,
wyhd_tp_pauza,
wyhd_klnapgaza,
wyhd_tp_pauzaposleraskladki,
kom_stol_abs,
kom_tp_prer,
kom_stol_stop,
kom_stol_ustnulq,
kom_stol_otn_wniz,
kom_stol_otn_wwerh,
kom_stol_obnulit_linejku,
kom_tjen1,
kom_tp_process,
kom_stol_peresch_t,
kom_laz_pit1,
kom_laz_got1,
kom_pitchil1,
kom_pitchil2,
kom_pitrec,
kom_pitmps,
kom_karlew_otn_wper_d,
kom_karlew_otn_nazad,
kom_karpraw_otn_wper_d,
kom_karpraw_otn_nazad,
kom_barpraw_wper_d,
kom_barpraw_nazad,
kom_barlew_wper_d,
kom_barlew_nazad,
kom_dozlew_wper,
kom_dozpraw_wper,
kom_tolklew_wper_d,
kom_tolklew_nazad,
kom_tolkpraw_wper_d,
kom_tolkpraw_nazad,
kom_dozlew_nazad,
kom_dozpraw_nazad,
kom_kje9_ohl_skan1,
kom_kje10_ohl_skan2,
kom_kv1,
kom_kv2,
kom_klbarlew,
kom_klbarpraw,
kom_nasotkgaza,
kom_barlew_stop,
kom_barpraw_stop,
kom_dozlew_stop,
kom_dozpraw_stop,
kom_karlew_stop,
kom_karpraw_stop,
kom_laz_got2,
kom_laz_pit2,
kom_sbrosawarii,
kom_blokirowki,
kom_tp_pauza,
kom_klnapgaza,
kom_tp_stop,
kom_tp_pauzaposleraskladki,
usttp_karpraw_skor,
usttp_karlew_skor,
usttp_tolkpraw_rasst,
usttp_tolkpraw_skor,
usttp_karpraw_rasst2,
usttp_dozpraw_wremq,
usttp_dozpraw_skor,
usttp_karpraw_rasst3,
usttp_karpraw_rasst4,
usttp_barpraw_skor,
usttp_karpraw_rasst5,
usttp_karlew_rasst1,
usttp_tolklew_rasst,
usttp_tolklew_skor,
usttp_karlew_rasst2,
usttp_dozlew_wremq,
usttp_dozlew_skor,
usttp_karlew_rasst3,
usttp_karlew_rasst4,
usttp_barlew_skor,
usttp_karlew_rasst5,
usttp_tolschsloq2,
usttp_pauza1,
usttp_tolschsloq1,
usttp_pauza2,
usttp_karpraw_rasst1,
usttp_barpraw_skorrask,
usttp_barpraw_koorpusk,
usttp_barpraw_koorstop,
usttp_barlew_skorrask,
usttp_barlew_koorpusk,
usttp_barlew_koorstop,
lastGTag,
separator,
};

public string [] debugNames = {
"������������1",
"������������������",
"��������������������",
"���������������������",
"��������",
"����1����������������",
"������������������������",
"�����������",
"������������1",
"������������2",
"������������3",
"������������4",
"������������5",
"������������6",
"���������1",
"���������2",
"�������������������������",
"����������������",
"���������������1",
"���������������2",
"�����",
"���������������������",
"����������������",
"����������������",
"������1�-�������1",
"������1�-�������2",
"������1�-�������2",
"������2�-�������1",
"������2�-�������2",
"������2�-�������3",
"��������������-���������",
"�������������-���������",
"����������",
"����������",
"���������1�-�����������",
"���������2�-�����������",
"������1�-�����������",
"������2�-�����������",
"��������������������",
"����������������",
"��������",
"���������",
"�����������",
"���������",
"���������",
"���������",
"������������",
"������������",
"������������",
"��������������-���������",
"��������������-�����������",
"��������������-��������",
"���������������-���������",
"���������������-�����������",
"���������������-��������",
"���������������-���������",
"��������������-���������",
"�������������-������",
"��������������-������",
"����������������-�����������",
"�����������������-�����������",
"��������������-���������",
"�������������-���������",
"����������������-���������",
"�����������������-���������",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"�",
"��������",
"�����������",
"�����",
"����������������",
"�����",
"������",
"�����������������",
"����1",
"��������",
"���������",
"��������������1",
"������������1",
"���������������1",
"���������������2",
"������-�������",
"�����������",
"��������������-������",
"��������������-������",
"���������������-������",
"���������������-������",
"���������������-������",
"���������������-������",
"��������������-������",
"��������������-������",
"�������������-������",
"��������������-������",
"����������������-������",
"����������������-������",
"�����������������-������",
"�����������������-������",
"�������������-������",
"��������������-������",
"���9���������������1",
"���10���������������2",
"���1",
"���2",
"����������������������",
"�����������������������",
"������",
"��������������-�����",
"���������������-�����",
"�������������-�����",
"��������������-�����",
"��������������-�����",
"���������������-�����",
"������������2",
"��������������2",
"������������",
"�����������",
"������",
"�������������������",
"�����",
"��������������������",
"���������������-���������",
"��������������-����������",
"�����������������-������",
"�����������������-��������������",
"���������������-������2",
"��������������-�������",
"��������������-���������",
"���������������-������3",
"���������������-������4",
"����������������-���������",
"���������������-������5",
"��������������-������1",
"����������������-������",
"����������������-��������������",
"��������������-������2",
"�������������-�������",
"�������������-���������",
"��������������-������3",
"��������������-������4",
"���������������-���������",
"��������������-������5",
"������������2",
"������1",
"������������1",
"������2",
"���������������-������1",
"���������������-����������������������",
"���������������-��������������",
"���������������-�����������������",
"��������������-����������������������",
"��������������-��������������",
"��������������-�����������������",
};

public string getDebugName(gTags tag) {return debugNames[(int)tag];}

 Func<string>[] sGetters  = new Func<string>[(int)gTags.lastGTag];
public string getSValue(gTags tag) { return sGetters[(int)tag]();}
public void init_sGetters () {
sGetters[(int)gTags.am_termopara1] =  gets_am_termopara1;
sGetters[(int)gTags.am_dif_datch_rash] =  gets_am_dif_datch_rash;
sGetters[(int)gTags.am_dawl_lew_fil_tr] =  gets_am_dawl_lew_fil_tr;
sGetters[(int)gTags.am_dawl_praw_fil_tr] =  gets_am_dawl_praw_fil_tr;
sGetters[(int)gTags.am_linejka] =  gets_am_linejka;
sGetters[(int)gTags.am_tjen1_tek_moschn] =  gets_am_tjen1_tek_moschn;
sGetters[(int)gTags.am_kar_lew_tek_poz] =  gets_am_kar_lew_tek_poz;
sGetters[(int)gTags.am_stol_tek_poz] =  gets_am_stol_tek_poz;
sGetters[(int)gTags.am_laz1_temp1] =  gets_am_laz1_temp1;
sGetters[(int)gTags.am_laz1_temp2] =  gets_am_laz1_temp2;
sGetters[(int)gTags.am_laz1_temp3] =  gets_am_laz1_temp3;
sGetters[(int)gTags.am_laz2_temp1] =  gets_am_laz2_temp1;
sGetters[(int)gTags.am_laz2_temp2] =  gets_am_laz2_temp2;
sGetters[(int)gTags.am_laz2_temp3] =  gets_am_laz2_temp3;
sGetters[(int)gTags.am_datch_kisl1] =  gets_am_datch_kisl1;
sGetters[(int)gTags.am_datch_kisl2] =  gets_am_datch_kisl2;
sGetters[(int)gTags.am_kar_praw_tek_poz] =  gets_am_kar_praw_tek_poz;
sGetters[(int)gTags.am_dawl_w_kamere] =  gets_am_dawl_w_kamere;
sGetters[(int)gTags.am_ohl_skan1] =  gets_am_ohl_skan1;
sGetters[(int)gTags.am_ohl_skan2] =  gets_am_ohl_skan2;
sGetters[(int)gTags.nomer] =  gets_nomer;
sGetters[(int)gTags.am_dawl_w_kamere_dubl_r] =  gets_am_dawl_w_kamere_dubl_r;
sGetters[(int)gTags.am_oxik] =  gets_am_oxik;
sGetters[(int)gTags.dm_stol_abs_domgot] =  gets_dm_stol_abs_domgot;
sGetters[(int)gTags.dm_laz1_prot1] =  gets_dm_laz1_prot1;
sGetters[(int)gTags.dm_laz1_prot2] =  gets_dm_laz1_prot2;
sGetters[(int)gTags.dm_laz1_prot3] =  gets_dm_laz1_prot3;
sGetters[(int)gTags.dm_laz2_prot1] =  gets_dm_laz2_prot1;
sGetters[(int)gTags.dm_laz2_prot2] =  gets_dm_laz2_prot2;
sGetters[(int)gTags.dm_laz2_prot3] =  gets_dm_laz2_prot3;
sGetters[(int)gTags.dm_karpraw_konc] =  gets_dm_karpraw_konc;
sGetters[(int)gTags.dm_karlew_konc] =  gets_dm_karlew_konc;
sGetters[(int)gTags.razreshenie] =  gets_razreshenie;
sGetters[(int)gTags.gotownost] =  gets_gotownost;
sGetters[(int)gTags.ind_skan1_ohl] =  gets_ind_skan1_ohl;
sGetters[(int)gTags.ind_skan2_ohl] =  gets_ind_skan2_ohl;
sGetters[(int)gTags.ind_laz1_ohl] =  gets_ind_laz1_ohl;
sGetters[(int)gTags.ind_laz2_ohl] =  gets_ind_laz2_ohl;
sGetters[(int)gTags.ind_kislorod] =  gets_ind_kislorod;
sGetters[(int)gTags.ind_dawlkam] =  gets_ind_dawlkam;
sGetters[(int)gTags.ust_stol_abs_poz] =  gets_ust_stol_abs_poz;
sGetters[(int)gTags.ust_stol_skor] =  gets_ust_stol_skor;
sGetters[(int)gTags.ust_stol_otn_rasst] =  gets_ust_stol_otn_rasst;
sGetters[(int)gTags.ust_tjen1_moschn] =  gets_ust_tjen1_moschn;
sGetters[(int)gTags.ust_tjen2_moschn] =  gets_ust_tjen2_moschn;
sGetters[(int)gTags.ust_tjen3_moschn] =  gets_ust_tjen3_moschn;
sGetters[(int)gTags.ust_tjen1_temp] =  gets_ust_tjen1_temp;
sGetters[(int)gTags.ust_tjen2_temp] =  gets_ust_tjen2_temp;
sGetters[(int)gTags.ust_tjen3_temp] =  gets_ust_tjen3_temp;
sGetters[(int)gTags.ust_karlew_skor] =  gets_ust_karlew_skor;
sGetters[(int)gTags.ust_karlew_otn_rast] =  gets_ust_karlew_otn_rast;
sGetters[(int)gTags.ust_karlew_abs_poz] =  gets_ust_karlew_abs_poz;
sGetters[(int)gTags.ust_karpraw_skor] =  gets_ust_karpraw_skor;
sGetters[(int)gTags.ust_karpraw_otn_rast] =  gets_ust_karpraw_otn_rast;
sGetters[(int)gTags.ust_karpraw_abs_poz] =  gets_ust_karpraw_abs_poz;
sGetters[(int)gTags.ust_barpraw_skor] =  gets_ust_barpraw_skor;
sGetters[(int)gTags.ust_barlew_skor] =  gets_ust_barlew_skor;
sGetters[(int)gTags.ust_dozlew_wremq] =  gets_ust_dozlew_wremq;
sGetters[(int)gTags.ust_dozpraw_wremq] =  gets_ust_dozpraw_wremq;
sGetters[(int)gTags.ust_tolklew_rasst] =  gets_ust_tolklew_rasst;
sGetters[(int)gTags.ust_tolkpraw_rasst] =  gets_ust_tolkpraw_rasst;
sGetters[(int)gTags.ust_dozpraw_skor] =  gets_ust_dozpraw_skor;
sGetters[(int)gTags.ust_dozlew_skor] =  gets_ust_dozlew_skor;
sGetters[(int)gTags.ust_tolklew_skor] =  gets_ust_tolklew_skor;
sGetters[(int)gTags.ust_tolkpraw_skor] =  gets_ust_tolkpraw_skor;
sGetters[(int)gTags.wyhd_stol_abs] =  gets_wyhd_stol_abs;
sGetters[(int)gTags.wyhd_tjen1_pit] =  gets_wyhd_tjen1_pit;
sGetters[(int)gTags.wyhd_stol_otn_wniz] =  gets_wyhd_stol_otn_wniz;
sGetters[(int)gTags.wyhd_stol_otn_wwerh] =  gets_wyhd_stol_otn_wwerh;
sGetters[(int)gTags.wyhd_laz_pit1] =  gets_wyhd_laz_pit1;
sGetters[(int)gTags.wyhd_pitchil1] =  gets_wyhd_pitchil1;
sGetters[(int)gTags.wyhd_pitchil2] =  gets_wyhd_pitchil2;
sGetters[(int)gTags.wyhd_pitmps] =  gets_wyhd_pitmps;
sGetters[(int)gTags.wyhd_pitrec] =  gets_wyhd_pitrec;
sGetters[(int)gTags.wyhd_kv1] =  gets_wyhd_kv1;
sGetters[(int)gTags.wyhd_kv2] =  gets_wyhd_kv2;
sGetters[(int)gTags.wyhd_kje9] =  gets_wyhd_kje9;
sGetters[(int)gTags.wyhd_kje10] =  gets_wyhd_kje10;
sGetters[(int)gTags.wyhd_karpraw_abs] =  gets_wyhd_karpraw_abs;
sGetters[(int)gTags.wyhd_karlew_abs] =  gets_wyhd_karlew_abs;
sGetters[(int)gTags.wyhd_dozpraw_wper] =  gets_wyhd_dozpraw_wper;
sGetters[(int)gTags.wyhd_dozlew_wper] =  gets_wyhd_dozlew_wper;
sGetters[(int)gTags.wyhd_dozpraw_nazad] =  gets_wyhd_dozpraw_nazad;
sGetters[(int)gTags.wyhd_dozlew_nazad] =  gets_wyhd_dozlew_nazad;
sGetters[(int)gTags.wyhd_stol_peresch_t] =  gets_wyhd_stol_peresch_t;
sGetters[(int)gTags.wyhd_barlew_wper_d] =  gets_wyhd_barlew_wper_d;
sGetters[(int)gTags.wyhd_barpraw_wper_d] =  gets_wyhd_barpraw_wper_d;
sGetters[(int)gTags.wyhd_barlew_nazad] =  gets_wyhd_barlew_nazad;
sGetters[(int)gTags.wyhd_barpraw_nazad] =  gets_wyhd_barpraw_nazad;
sGetters[(int)gTags.wyhd_tolklew_wper_d] =  gets_wyhd_tolklew_wper_d;
sGetters[(int)gTags.wyhd_tolkpraw_wper_d] =  gets_wyhd_tolkpraw_wper_d;
sGetters[(int)gTags.wyhd_tolklew_nazad] =  gets_wyhd_tolklew_nazad;
sGetters[(int)gTags.wyhd_tolkpraw_nazad] =  gets_wyhd_tolkpraw_nazad;
sGetters[(int)gTags.wyhd_karpraw_otn_wper_d] =  gets_wyhd_karpraw_otn_wper_d;
sGetters[(int)gTags.wyhd_karpraw_otn_nazad] =  gets_wyhd_karpraw_otn_nazad;
sGetters[(int)gTags.wyhd_karlew_otn_wper_d] =  gets_wyhd_karlew_otn_wper_d;
sGetters[(int)gTags.wyhd_karlew_otn_nazad] =  gets_wyhd_karlew_otn_nazad;
sGetters[(int)gTags.wyhd_klbarlew] =  gets_wyhd_klbarlew;
sGetters[(int)gTags.wyhd_klbarpraw] =  gets_wyhd_klbarpraw;
sGetters[(int)gTags.wyhd_nasotkgaza] =  gets_wyhd_nasotkgaza;
sGetters[(int)gTags.wyhd_tp_sloj_rab1] =  gets_wyhd_tp_sloj_rab1;
sGetters[(int)gTags.wyhd_tp_process] =  gets_wyhd_tp_process;
sGetters[(int)gTags.wyhd_laz_pit2] =  gets_wyhd_laz_pit2;
sGetters[(int)gTags.wyhd_tp_sloj_rab2] =  gets_wyhd_tp_sloj_rab2;
sGetters[(int)gTags.wyhd_tp_sloj_rab3] =  gets_wyhd_tp_sloj_rab3;
sGetters[(int)gTags.wyhd_blokirowki] =  gets_wyhd_blokirowki;
sGetters[(int)gTags.wyhd_tp_pauza] =  gets_wyhd_tp_pauza;
sGetters[(int)gTags.wyhd_klnapgaza] =  gets_wyhd_klnapgaza;
sGetters[(int)gTags.wyhd_tp_pauzaposleraskladki] =  gets_wyhd_tp_pauzaposleraskladki;
sGetters[(int)gTags.kom_stol_abs] =  gets_kom_stol_abs;
sGetters[(int)gTags.kom_tp_prer] =  gets_kom_tp_prer;
sGetters[(int)gTags.kom_stol_stop] =  gets_kom_stol_stop;
sGetters[(int)gTags.kom_stol_ustnulq] =  gets_kom_stol_ustnulq;
sGetters[(int)gTags.kom_stol_otn_wniz] =  gets_kom_stol_otn_wniz;
sGetters[(int)gTags.kom_stol_otn_wwerh] =  gets_kom_stol_otn_wwerh;
sGetters[(int)gTags.kom_stol_obnulit_linejku] =  gets_kom_stol_obnulit_linejku;
sGetters[(int)gTags.kom_tjen1] =  gets_kom_tjen1;
sGetters[(int)gTags.kom_tp_process] =  gets_kom_tp_process;
sGetters[(int)gTags.kom_stol_peresch_t] =  gets_kom_stol_peresch_t;
sGetters[(int)gTags.kom_laz_pit1] =  gets_kom_laz_pit1;
sGetters[(int)gTags.kom_laz_got1] =  gets_kom_laz_got1;
sGetters[(int)gTags.kom_pitchil1] =  gets_kom_pitchil1;
sGetters[(int)gTags.kom_pitchil2] =  gets_kom_pitchil2;
sGetters[(int)gTags.kom_pitrec] =  gets_kom_pitrec;
sGetters[(int)gTags.kom_pitmps] =  gets_kom_pitmps;
sGetters[(int)gTags.kom_karlew_otn_wper_d] =  gets_kom_karlew_otn_wper_d;
sGetters[(int)gTags.kom_karlew_otn_nazad] =  gets_kom_karlew_otn_nazad;
sGetters[(int)gTags.kom_karpraw_otn_wper_d] =  gets_kom_karpraw_otn_wper_d;
sGetters[(int)gTags.kom_karpraw_otn_nazad] =  gets_kom_karpraw_otn_nazad;
sGetters[(int)gTags.kom_barpraw_wper_d] =  gets_kom_barpraw_wper_d;
sGetters[(int)gTags.kom_barpraw_nazad] =  gets_kom_barpraw_nazad;
sGetters[(int)gTags.kom_barlew_wper_d] =  gets_kom_barlew_wper_d;
sGetters[(int)gTags.kom_barlew_nazad] =  gets_kom_barlew_nazad;
sGetters[(int)gTags.kom_dozlew_wper] =  gets_kom_dozlew_wper;
sGetters[(int)gTags.kom_dozpraw_wper] =  gets_kom_dozpraw_wper;
sGetters[(int)gTags.kom_tolklew_wper_d] =  gets_kom_tolklew_wper_d;
sGetters[(int)gTags.kom_tolklew_nazad] =  gets_kom_tolklew_nazad;
sGetters[(int)gTags.kom_tolkpraw_wper_d] =  gets_kom_tolkpraw_wper_d;
sGetters[(int)gTags.kom_tolkpraw_nazad] =  gets_kom_tolkpraw_nazad;
sGetters[(int)gTags.kom_dozlew_nazad] =  gets_kom_dozlew_nazad;
sGetters[(int)gTags.kom_dozpraw_nazad] =  gets_kom_dozpraw_nazad;
sGetters[(int)gTags.kom_kje9_ohl_skan1] =  gets_kom_kje9_ohl_skan1;
sGetters[(int)gTags.kom_kje10_ohl_skan2] =  gets_kom_kje10_ohl_skan2;
sGetters[(int)gTags.kom_kv1] =  gets_kom_kv1;
sGetters[(int)gTags.kom_kv2] =  gets_kom_kv2;
sGetters[(int)gTags.kom_klbarlew] =  gets_kom_klbarlew;
sGetters[(int)gTags.kom_klbarpraw] =  gets_kom_klbarpraw;
sGetters[(int)gTags.kom_nasotkgaza] =  gets_kom_nasotkgaza;
sGetters[(int)gTags.kom_barlew_stop] =  gets_kom_barlew_stop;
sGetters[(int)gTags.kom_barpraw_stop] =  gets_kom_barpraw_stop;
sGetters[(int)gTags.kom_dozlew_stop] =  gets_kom_dozlew_stop;
sGetters[(int)gTags.kom_dozpraw_stop] =  gets_kom_dozpraw_stop;
sGetters[(int)gTags.kom_karlew_stop] =  gets_kom_karlew_stop;
sGetters[(int)gTags.kom_karpraw_stop] =  gets_kom_karpraw_stop;
sGetters[(int)gTags.kom_laz_got2] =  gets_kom_laz_got2;
sGetters[(int)gTags.kom_laz_pit2] =  gets_kom_laz_pit2;
sGetters[(int)gTags.kom_sbrosawarii] =  gets_kom_sbrosawarii;
sGetters[(int)gTags.kom_blokirowki] =  gets_kom_blokirowki;
sGetters[(int)gTags.kom_tp_pauza] =  gets_kom_tp_pauza;
sGetters[(int)gTags.kom_klnapgaza] =  gets_kom_klnapgaza;
sGetters[(int)gTags.kom_tp_stop] =  gets_kom_tp_stop;
sGetters[(int)gTags.kom_tp_pauzaposleraskladki] =  gets_kom_tp_pauzaposleraskladki;
sGetters[(int)gTags.usttp_karpraw_skor] =  gets_usttp_karpraw_skor;
sGetters[(int)gTags.usttp_karlew_skor] =  gets_usttp_karlew_skor;
sGetters[(int)gTags.usttp_tolkpraw_rasst] =  gets_usttp_tolkpraw_rasst;
sGetters[(int)gTags.usttp_tolkpraw_skor] =  gets_usttp_tolkpraw_skor;
sGetters[(int)gTags.usttp_karpraw_rasst2] =  gets_usttp_karpraw_rasst2;
sGetters[(int)gTags.usttp_dozpraw_wremq] =  gets_usttp_dozpraw_wremq;
sGetters[(int)gTags.usttp_dozpraw_skor] =  gets_usttp_dozpraw_skor;
sGetters[(int)gTags.usttp_karpraw_rasst3] =  gets_usttp_karpraw_rasst3;
sGetters[(int)gTags.usttp_karpraw_rasst4] =  gets_usttp_karpraw_rasst4;
sGetters[(int)gTags.usttp_barpraw_skor] =  gets_usttp_barpraw_skor;
sGetters[(int)gTags.usttp_karpraw_rasst5] =  gets_usttp_karpraw_rasst5;
sGetters[(int)gTags.usttp_karlew_rasst1] =  gets_usttp_karlew_rasst1;
sGetters[(int)gTags.usttp_tolklew_rasst] =  gets_usttp_tolklew_rasst;
sGetters[(int)gTags.usttp_tolklew_skor] =  gets_usttp_tolklew_skor;
sGetters[(int)gTags.usttp_karlew_rasst2] =  gets_usttp_karlew_rasst2;
sGetters[(int)gTags.usttp_dozlew_wremq] =  gets_usttp_dozlew_wremq;
sGetters[(int)gTags.usttp_dozlew_skor] =  gets_usttp_dozlew_skor;
sGetters[(int)gTags.usttp_karlew_rasst3] =  gets_usttp_karlew_rasst3;
sGetters[(int)gTags.usttp_karlew_rasst4] =  gets_usttp_karlew_rasst4;
sGetters[(int)gTags.usttp_barlew_skor] =  gets_usttp_barlew_skor;
sGetters[(int)gTags.usttp_karlew_rasst5] =  gets_usttp_karlew_rasst5;
sGetters[(int)gTags.usttp_tolschsloq2] =  gets_usttp_tolschsloq2;
sGetters[(int)gTags.usttp_pauza1] =  gets_usttp_pauza1;
sGetters[(int)gTags.usttp_tolschsloq1] =  gets_usttp_tolschsloq1;
sGetters[(int)gTags.usttp_pauza2] =  gets_usttp_pauza2;
sGetters[(int)gTags.usttp_karpraw_rasst1] =  gets_usttp_karpraw_rasst1;
sGetters[(int)gTags.usttp_barpraw_skorrask] =  gets_usttp_barpraw_skorrask;
sGetters[(int)gTags.usttp_barpraw_koorpusk] =  gets_usttp_barpraw_koorpusk;
sGetters[(int)gTags.usttp_barpraw_koorstop] =  gets_usttp_barpraw_koorstop;
sGetters[(int)gTags.usttp_barlew_skorrask] =  gets_usttp_barlew_skorrask;
sGetters[(int)gTags.usttp_barlew_koorpusk] =  gets_usttp_barlew_koorpusk;
sGetters[(int)gTags.usttp_barlew_koorstop] =  gets_usttp_barlew_koorstop;
}

Func<string, bool>[] sSetters = new Func<string, bool>[(int)gTags.lastGTag];
public bool setSValue(gTags tag, string val) { return sSetters[(int)tag](val); }
public void init_sSetters () {
sSetters[(int)gTags.am_termopara1] =  sets_am_termopara1;
sSetters[(int)gTags.am_dif_datch_rash] =  sets_am_dif_datch_rash;
sSetters[(int)gTags.am_dawl_lew_fil_tr] =  sets_am_dawl_lew_fil_tr;
sSetters[(int)gTags.am_dawl_praw_fil_tr] =  sets_am_dawl_praw_fil_tr;
sSetters[(int)gTags.am_linejka] =  sets_am_linejka;
sSetters[(int)gTags.am_tjen1_tek_moschn] =  sets_am_tjen1_tek_moschn;
sSetters[(int)gTags.am_kar_lew_tek_poz] =  sets_am_kar_lew_tek_poz;
sSetters[(int)gTags.am_stol_tek_poz] =  sets_am_stol_tek_poz;
sSetters[(int)gTags.am_laz1_temp1] =  sets_am_laz1_temp1;
sSetters[(int)gTags.am_laz1_temp2] =  sets_am_laz1_temp2;
sSetters[(int)gTags.am_laz1_temp3] =  sets_am_laz1_temp3;
sSetters[(int)gTags.am_laz2_temp1] =  sets_am_laz2_temp1;
sSetters[(int)gTags.am_laz2_temp2] =  sets_am_laz2_temp2;
sSetters[(int)gTags.am_laz2_temp3] =  sets_am_laz2_temp3;
sSetters[(int)gTags.am_datch_kisl1] =  sets_am_datch_kisl1;
sSetters[(int)gTags.am_datch_kisl2] =  sets_am_datch_kisl2;
sSetters[(int)gTags.am_kar_praw_tek_poz] =  sets_am_kar_praw_tek_poz;
sSetters[(int)gTags.am_dawl_w_kamere] =  sets_am_dawl_w_kamere;
sSetters[(int)gTags.am_ohl_skan1] =  sets_am_ohl_skan1;
sSetters[(int)gTags.am_ohl_skan2] =  sets_am_ohl_skan2;
sSetters[(int)gTags.nomer] =  sets_nomer;
sSetters[(int)gTags.am_dawl_w_kamere_dubl_r] =  sets_am_dawl_w_kamere_dubl_r;
sSetters[(int)gTags.am_oxik] =  sets_am_oxik;
sSetters[(int)gTags.dm_stol_abs_domgot] =  sets_dm_stol_abs_domgot;
sSetters[(int)gTags.dm_laz1_prot1] =  sets_dm_laz1_prot1;
sSetters[(int)gTags.dm_laz1_prot2] =  sets_dm_laz1_prot2;
sSetters[(int)gTags.dm_laz1_prot3] =  sets_dm_laz1_prot3;
sSetters[(int)gTags.dm_laz2_prot1] =  sets_dm_laz2_prot1;
sSetters[(int)gTags.dm_laz2_prot2] =  sets_dm_laz2_prot2;
sSetters[(int)gTags.dm_laz2_prot3] =  sets_dm_laz2_prot3;
sSetters[(int)gTags.dm_karpraw_konc] =  sets_dm_karpraw_konc;
sSetters[(int)gTags.dm_karlew_konc] =  sets_dm_karlew_konc;
sSetters[(int)gTags.razreshenie] =  sets_razreshenie;
sSetters[(int)gTags.gotownost] =  sets_gotownost;
sSetters[(int)gTags.ind_skan1_ohl] =  sets_ind_skan1_ohl;
sSetters[(int)gTags.ind_skan2_ohl] =  sets_ind_skan2_ohl;
sSetters[(int)gTags.ind_laz1_ohl] =  sets_ind_laz1_ohl;
sSetters[(int)gTags.ind_laz2_ohl] =  sets_ind_laz2_ohl;
sSetters[(int)gTags.ind_kislorod] =  sets_ind_kislorod;
sSetters[(int)gTags.ind_dawlkam] =  sets_ind_dawlkam;
sSetters[(int)gTags.ust_stol_abs_poz] =  sets_ust_stol_abs_poz;
sSetters[(int)gTags.ust_stol_skor] =  sets_ust_stol_skor;
sSetters[(int)gTags.ust_stol_otn_rasst] =  sets_ust_stol_otn_rasst;
sSetters[(int)gTags.ust_tjen1_moschn] =  sets_ust_tjen1_moschn;
sSetters[(int)gTags.ust_tjen2_moschn] =  sets_ust_tjen2_moschn;
sSetters[(int)gTags.ust_tjen3_moschn] =  sets_ust_tjen3_moschn;
sSetters[(int)gTags.ust_tjen1_temp] =  sets_ust_tjen1_temp;
sSetters[(int)gTags.ust_tjen2_temp] =  sets_ust_tjen2_temp;
sSetters[(int)gTags.ust_tjen3_temp] =  sets_ust_tjen3_temp;
sSetters[(int)gTags.ust_karlew_skor] =  sets_ust_karlew_skor;
sSetters[(int)gTags.ust_karlew_otn_rast] =  sets_ust_karlew_otn_rast;
sSetters[(int)gTags.ust_karlew_abs_poz] =  sets_ust_karlew_abs_poz;
sSetters[(int)gTags.ust_karpraw_skor] =  sets_ust_karpraw_skor;
sSetters[(int)gTags.ust_karpraw_otn_rast] =  sets_ust_karpraw_otn_rast;
sSetters[(int)gTags.ust_karpraw_abs_poz] =  sets_ust_karpraw_abs_poz;
sSetters[(int)gTags.ust_barpraw_skor] =  sets_ust_barpraw_skor;
sSetters[(int)gTags.ust_barlew_skor] =  sets_ust_barlew_skor;
sSetters[(int)gTags.ust_dozlew_wremq] =  sets_ust_dozlew_wremq;
sSetters[(int)gTags.ust_dozpraw_wremq] =  sets_ust_dozpraw_wremq;
sSetters[(int)gTags.ust_tolklew_rasst] =  sets_ust_tolklew_rasst;
sSetters[(int)gTags.ust_tolkpraw_rasst] =  sets_ust_tolkpraw_rasst;
sSetters[(int)gTags.ust_dozpraw_skor] =  sets_ust_dozpraw_skor;
sSetters[(int)gTags.ust_dozlew_skor] =  sets_ust_dozlew_skor;
sSetters[(int)gTags.ust_tolklew_skor] =  sets_ust_tolklew_skor;
sSetters[(int)gTags.ust_tolkpraw_skor] =  sets_ust_tolkpraw_skor;
sSetters[(int)gTags.wyhd_stol_abs] =  sets_wyhd_stol_abs;
sSetters[(int)gTags.wyhd_tjen1_pit] =  sets_wyhd_tjen1_pit;
sSetters[(int)gTags.wyhd_stol_otn_wniz] =  sets_wyhd_stol_otn_wniz;
sSetters[(int)gTags.wyhd_stol_otn_wwerh] =  sets_wyhd_stol_otn_wwerh;
sSetters[(int)gTags.wyhd_laz_pit1] =  sets_wyhd_laz_pit1;
sSetters[(int)gTags.wyhd_pitchil1] =  sets_wyhd_pitchil1;
sSetters[(int)gTags.wyhd_pitchil2] =  sets_wyhd_pitchil2;
sSetters[(int)gTags.wyhd_pitmps] =  sets_wyhd_pitmps;
sSetters[(int)gTags.wyhd_pitrec] =  sets_wyhd_pitrec;
sSetters[(int)gTags.wyhd_kv1] =  sets_wyhd_kv1;
sSetters[(int)gTags.wyhd_kv2] =  sets_wyhd_kv2;
sSetters[(int)gTags.wyhd_kje9] =  sets_wyhd_kje9;
sSetters[(int)gTags.wyhd_kje10] =  sets_wyhd_kje10;
sSetters[(int)gTags.wyhd_karpraw_abs] =  sets_wyhd_karpraw_abs;
sSetters[(int)gTags.wyhd_karlew_abs] =  sets_wyhd_karlew_abs;
sSetters[(int)gTags.wyhd_dozpraw_wper] =  sets_wyhd_dozpraw_wper;
sSetters[(int)gTags.wyhd_dozlew_wper] =  sets_wyhd_dozlew_wper;
sSetters[(int)gTags.wyhd_dozpraw_nazad] =  sets_wyhd_dozpraw_nazad;
sSetters[(int)gTags.wyhd_dozlew_nazad] =  sets_wyhd_dozlew_nazad;
sSetters[(int)gTags.wyhd_stol_peresch_t] =  sets_wyhd_stol_peresch_t;
sSetters[(int)gTags.wyhd_barlew_wper_d] =  sets_wyhd_barlew_wper_d;
sSetters[(int)gTags.wyhd_barpraw_wper_d] =  sets_wyhd_barpraw_wper_d;
sSetters[(int)gTags.wyhd_barlew_nazad] =  sets_wyhd_barlew_nazad;
sSetters[(int)gTags.wyhd_barpraw_nazad] =  sets_wyhd_barpraw_nazad;
sSetters[(int)gTags.wyhd_tolklew_wper_d] =  sets_wyhd_tolklew_wper_d;
sSetters[(int)gTags.wyhd_tolkpraw_wper_d] =  sets_wyhd_tolkpraw_wper_d;
sSetters[(int)gTags.wyhd_tolklew_nazad] =  sets_wyhd_tolklew_nazad;
sSetters[(int)gTags.wyhd_tolkpraw_nazad] =  sets_wyhd_tolkpraw_nazad;
sSetters[(int)gTags.wyhd_karpraw_otn_wper_d] =  sets_wyhd_karpraw_otn_wper_d;
sSetters[(int)gTags.wyhd_karpraw_otn_nazad] =  sets_wyhd_karpraw_otn_nazad;
sSetters[(int)gTags.wyhd_karlew_otn_wper_d] =  sets_wyhd_karlew_otn_wper_d;
sSetters[(int)gTags.wyhd_karlew_otn_nazad] =  sets_wyhd_karlew_otn_nazad;
sSetters[(int)gTags.wyhd_klbarlew] =  sets_wyhd_klbarlew;
sSetters[(int)gTags.wyhd_klbarpraw] =  sets_wyhd_klbarpraw;
sSetters[(int)gTags.wyhd_nasotkgaza] =  sets_wyhd_nasotkgaza;
sSetters[(int)gTags.wyhd_tp_sloj_rab1] =  sets_wyhd_tp_sloj_rab1;
sSetters[(int)gTags.wyhd_tp_process] =  sets_wyhd_tp_process;
sSetters[(int)gTags.wyhd_laz_pit2] =  sets_wyhd_laz_pit2;
sSetters[(int)gTags.wyhd_tp_sloj_rab2] =  sets_wyhd_tp_sloj_rab2;
sSetters[(int)gTags.wyhd_tp_sloj_rab3] =  sets_wyhd_tp_sloj_rab3;
sSetters[(int)gTags.wyhd_blokirowki] =  sets_wyhd_blokirowki;
sSetters[(int)gTags.wyhd_tp_pauza] =  sets_wyhd_tp_pauza;
sSetters[(int)gTags.wyhd_klnapgaza] =  sets_wyhd_klnapgaza;
sSetters[(int)gTags.wyhd_tp_pauzaposleraskladki] =  sets_wyhd_tp_pauzaposleraskladki;
sSetters[(int)gTags.kom_stol_abs] =  sets_kom_stol_abs;
sSetters[(int)gTags.kom_tp_prer] =  sets_kom_tp_prer;
sSetters[(int)gTags.kom_stol_stop] =  sets_kom_stol_stop;
sSetters[(int)gTags.kom_stol_ustnulq] =  sets_kom_stol_ustnulq;
sSetters[(int)gTags.kom_stol_otn_wniz] =  sets_kom_stol_otn_wniz;
sSetters[(int)gTags.kom_stol_otn_wwerh] =  sets_kom_stol_otn_wwerh;
sSetters[(int)gTags.kom_stol_obnulit_linejku] =  sets_kom_stol_obnulit_linejku;
sSetters[(int)gTags.kom_tjen1] =  sets_kom_tjen1;
sSetters[(int)gTags.kom_tp_process] =  sets_kom_tp_process;
sSetters[(int)gTags.kom_stol_peresch_t] =  sets_kom_stol_peresch_t;
sSetters[(int)gTags.kom_laz_pit1] =  sets_kom_laz_pit1;
sSetters[(int)gTags.kom_laz_got1] =  sets_kom_laz_got1;
sSetters[(int)gTags.kom_pitchil1] =  sets_kom_pitchil1;
sSetters[(int)gTags.kom_pitchil2] =  sets_kom_pitchil2;
sSetters[(int)gTags.kom_pitrec] =  sets_kom_pitrec;
sSetters[(int)gTags.kom_pitmps] =  sets_kom_pitmps;
sSetters[(int)gTags.kom_karlew_otn_wper_d] =  sets_kom_karlew_otn_wper_d;
sSetters[(int)gTags.kom_karlew_otn_nazad] =  sets_kom_karlew_otn_nazad;
sSetters[(int)gTags.kom_karpraw_otn_wper_d] =  sets_kom_karpraw_otn_wper_d;
sSetters[(int)gTags.kom_karpraw_otn_nazad] =  sets_kom_karpraw_otn_nazad;
sSetters[(int)gTags.kom_barpraw_wper_d] =  sets_kom_barpraw_wper_d;
sSetters[(int)gTags.kom_barpraw_nazad] =  sets_kom_barpraw_nazad;
sSetters[(int)gTags.kom_barlew_wper_d] =  sets_kom_barlew_wper_d;
sSetters[(int)gTags.kom_barlew_nazad] =  sets_kom_barlew_nazad;
sSetters[(int)gTags.kom_dozlew_wper] =  sets_kom_dozlew_wper;
sSetters[(int)gTags.kom_dozpraw_wper] =  sets_kom_dozpraw_wper;
sSetters[(int)gTags.kom_tolklew_wper_d] =  sets_kom_tolklew_wper_d;
sSetters[(int)gTags.kom_tolklew_nazad] =  sets_kom_tolklew_nazad;
sSetters[(int)gTags.kom_tolkpraw_wper_d] =  sets_kom_tolkpraw_wper_d;
sSetters[(int)gTags.kom_tolkpraw_nazad] =  sets_kom_tolkpraw_nazad;
sSetters[(int)gTags.kom_dozlew_nazad] =  sets_kom_dozlew_nazad;
sSetters[(int)gTags.kom_dozpraw_nazad] =  sets_kom_dozpraw_nazad;
sSetters[(int)gTags.kom_kje9_ohl_skan1] =  sets_kom_kje9_ohl_skan1;
sSetters[(int)gTags.kom_kje10_ohl_skan2] =  sets_kom_kje10_ohl_skan2;
sSetters[(int)gTags.kom_kv1] =  sets_kom_kv1;
sSetters[(int)gTags.kom_kv2] =  sets_kom_kv2;
sSetters[(int)gTags.kom_klbarlew] =  sets_kom_klbarlew;
sSetters[(int)gTags.kom_klbarpraw] =  sets_kom_klbarpraw;
sSetters[(int)gTags.kom_nasotkgaza] =  sets_kom_nasotkgaza;
sSetters[(int)gTags.kom_barlew_stop] =  sets_kom_barlew_stop;
sSetters[(int)gTags.kom_barpraw_stop] =  sets_kom_barpraw_stop;
sSetters[(int)gTags.kom_dozlew_stop] =  sets_kom_dozlew_stop;
sSetters[(int)gTags.kom_dozpraw_stop] =  sets_kom_dozpraw_stop;
sSetters[(int)gTags.kom_karlew_stop] =  sets_kom_karlew_stop;
sSetters[(int)gTags.kom_karpraw_stop] =  sets_kom_karpraw_stop;
sSetters[(int)gTags.kom_laz_got2] =  sets_kom_laz_got2;
sSetters[(int)gTags.kom_laz_pit2] =  sets_kom_laz_pit2;
sSetters[(int)gTags.kom_sbrosawarii] =  sets_kom_sbrosawarii;
sSetters[(int)gTags.kom_blokirowki] =  sets_kom_blokirowki;
sSetters[(int)gTags.kom_tp_pauza] =  sets_kom_tp_pauza;
sSetters[(int)gTags.kom_klnapgaza] =  sets_kom_klnapgaza;
sSetters[(int)gTags.kom_tp_stop] =  sets_kom_tp_stop;
sSetters[(int)gTags.kom_tp_pauzaposleraskladki] =  sets_kom_tp_pauzaposleraskladki;
sSetters[(int)gTags.usttp_karpraw_skor] =  sets_usttp_karpraw_skor;
sSetters[(int)gTags.usttp_karlew_skor] =  sets_usttp_karlew_skor;
sSetters[(int)gTags.usttp_tolkpraw_rasst] =  sets_usttp_tolkpraw_rasst;
sSetters[(int)gTags.usttp_tolkpraw_skor] =  sets_usttp_tolkpraw_skor;
sSetters[(int)gTags.usttp_karpraw_rasst2] =  sets_usttp_karpraw_rasst2;
sSetters[(int)gTags.usttp_dozpraw_wremq] =  sets_usttp_dozpraw_wremq;
sSetters[(int)gTags.usttp_dozpraw_skor] =  sets_usttp_dozpraw_skor;
sSetters[(int)gTags.usttp_karpraw_rasst3] =  sets_usttp_karpraw_rasst3;
sSetters[(int)gTags.usttp_karpraw_rasst4] =  sets_usttp_karpraw_rasst4;
sSetters[(int)gTags.usttp_barpraw_skor] =  sets_usttp_barpraw_skor;
sSetters[(int)gTags.usttp_karpraw_rasst5] =  sets_usttp_karpraw_rasst5;
sSetters[(int)gTags.usttp_karlew_rasst1] =  sets_usttp_karlew_rasst1;
sSetters[(int)gTags.usttp_tolklew_rasst] =  sets_usttp_tolklew_rasst;
sSetters[(int)gTags.usttp_tolklew_skor] =  sets_usttp_tolklew_skor;
sSetters[(int)gTags.usttp_karlew_rasst2] =  sets_usttp_karlew_rasst2;
sSetters[(int)gTags.usttp_dozlew_wremq] =  sets_usttp_dozlew_wremq;
sSetters[(int)gTags.usttp_dozlew_skor] =  sets_usttp_dozlew_skor;
sSetters[(int)gTags.usttp_karlew_rasst3] =  sets_usttp_karlew_rasst3;
sSetters[(int)gTags.usttp_karlew_rasst4] =  sets_usttp_karlew_rasst4;
sSetters[(int)gTags.usttp_barlew_skor] =  sets_usttp_barlew_skor;
sSetters[(int)gTags.usttp_karlew_rasst5] =  sets_usttp_karlew_rasst5;
sSetters[(int)gTags.usttp_tolschsloq2] =  sets_usttp_tolschsloq2;
sSetters[(int)gTags.usttp_pauza1] =  sets_usttp_pauza1;
sSetters[(int)gTags.usttp_tolschsloq1] =  sets_usttp_tolschsloq1;
sSetters[(int)gTags.usttp_pauza2] =  sets_usttp_pauza2;
sSetters[(int)gTags.usttp_karpraw_rasst1] =  sets_usttp_karpraw_rasst1;
sSetters[(int)gTags.usttp_barpraw_skorrask] =  sets_usttp_barpraw_skorrask;
sSetters[(int)gTags.usttp_barpraw_koorpusk] =  sets_usttp_barpraw_koorpusk;
sSetters[(int)gTags.usttp_barpraw_koorstop] =  sets_usttp_barpraw_koorstop;
sSetters[(int)gTags.usttp_barlew_skorrask] =  sets_usttp_barlew_skorrask;
sSetters[(int)gTags.usttp_barlew_koorpusk] =  sets_usttp_barlew_koorpusk;
sSetters[(int)gTags.usttp_barlew_koorstop] =  sets_usttp_barlew_koorstop;
}

public Dictionary<string, gTags[]> groupingDict = new Dictionary<string, gTags[]> {
{ "�����������" ,new gTags [] {
gTags.separator,
gTags.am_tjen1_tek_moschn,
gTags.kom_tjen1,
gTags.ust_tjen1_moschn,
gTags.ust_tjen1_temp,
gTags.wyhd_tjen1_pit,
gTags.separator,
gTags.am_termopara1,
gTags.ust_tjen2_moschn,
gTags.ust_tjen2_temp,
gTags.ust_tjen3_moschn,
gTags.ust_tjen3_temp,
}},
{ "������������" ,new gTags [] {
gTags.separator,
gTags.am_dawl_w_kamere,
gTags.am_dawl_w_kamere_dubl_r,
gTags.separator,
gTags.kom_klnapgaza,
gTags.wyhd_klnapgaza,
gTags.separator,
gTags.kom_kv1,
gTags.wyhd_kv1,
gTags.separator,
gTags.kom_kv2,
gTags.wyhd_kv2,
gTags.separator,
gTags.kom_pitrec,
gTags.wyhd_pitrec,
gTags.separator,
gTags.am_datch_kisl1,
gTags.am_datch_kisl2,
gTags.separator,
gTags.am_dawl_lew_fil_tr,
gTags.am_dawl_praw_fil_tr,
gTags.separator,
gTags.am_dif_datch_rash,
gTags.am_oxik,
}},
{ "����" ,new gTags [] {
gTags.separator,
gTags.kom_stol_abs,
gTags.ust_stol_abs_poz,
gTags.wyhd_stol_abs,
gTags.separator,
gTags.kom_stol_otn_wniz,
gTags.wyhd_stol_otn_wniz,
gTags.separator,
gTags.kom_stol_otn_wwerh,
gTags.wyhd_stol_otn_wwerh,
gTags.separator,
gTags.kom_stol_peresch_t,
gTags.wyhd_stol_peresch_t,
gTags.separator,
gTags.am_linejka,
gTags.am_stol_tek_poz,
gTags.dm_stol_abs_domgot,
gTags.separator,
gTags.kom_stol_obnulit_linejku,
gTags.kom_stol_stop,
gTags.kom_stol_ustnulq,
gTags.separator,
gTags.ust_stol_otn_rasst,
gTags.ust_stol_skor,
}},
{ "�������" ,new gTags [] {
gTags.separator,
gTags.kom_karlew_otn_nazad,
gTags.wyhd_karlew_otn_nazad,
gTags.separator,
gTags.kom_karlew_otn_wper_d,
gTags.wyhd_karlew_otn_wper_d,
gTags.separator,
gTags.kom_karpraw_otn_nazad,
gTags.wyhd_karpraw_otn_nazad,
gTags.separator,
gTags.kom_karpraw_otn_wper_d,
gTags.wyhd_karpraw_otn_wper_d,
gTags.separator,
gTags.kom_pitmps,
gTags.wyhd_pitmps,
gTags.separator,
gTags.ust_karlew_abs_poz,
gTags.wyhd_karlew_abs,
gTags.separator,
gTags.ust_karpraw_abs_poz,
gTags.wyhd_karpraw_abs,
gTags.separator,
gTags.am_kar_lew_tek_poz,
gTags.am_kar_praw_tek_poz,
gTags.separator,
gTags.dm_karlew_konc,
gTags.dm_karpraw_konc,
gTags.separator,
gTags.kom_karlew_stop,
gTags.kom_karpraw_stop,
gTags.separator,
gTags.ust_karlew_otn_rast,
gTags.ust_karlew_skor,
gTags.separator,
gTags.ust_karpraw_otn_rast,
gTags.ust_karpraw_skor,
}},
{ "�������" ,new gTags [] {
gTags.separator,
gTags.kom_pitchil1,
gTags.wyhd_pitchil1,
gTags.separator,
gTags.kom_pitchil2,
gTags.wyhd_pitchil2,
gTags.separator,
gTags.am_laz1_temp1,
gTags.am_laz1_temp2,
gTags.separator,
gTags.am_laz1_temp3,
gTags.am_laz2_temp1,
gTags.separator,
gTags.am_laz2_temp2,
gTags.am_laz2_temp3,
gTags.separator,
gTags.dm_laz1_prot1,
gTags.dm_laz1_prot2,
gTags.separator,
gTags.dm_laz1_prot3,
gTags.dm_laz2_prot1,
gTags.separator,
gTags.dm_laz2_prot2,
gTags.dm_laz2_prot3,
}},
{ "������" ,new gTags [] {
gTags.separator,
gTags.kom_blokirowki,
gTags.wyhd_blokirowki,
gTags.separator,
gTags.kom_laz_pit1,
gTags.wyhd_laz_pit1,
gTags.separator,
gTags.kom_laz_pit2,
gTags.wyhd_laz_pit2,
gTags.separator,
gTags.kom_kje10_ohl_skan2,
gTags.wyhd_kje10,
gTags.separator,
gTags.kom_kje9_ohl_skan1,
gTags.wyhd_kje9,
gTags.separator,
gTags.am_ohl_skan1,
gTags.am_ohl_skan2,
gTags.separator,
gTags.ind_dawlkam,
gTags.ind_kislorod,
gTags.separator,
gTags.ind_laz1_ohl,
gTags.ind_laz2_ohl,
gTags.separator,
gTags.ind_skan1_ohl,
gTags.ind_skan2_ohl,
gTags.separator,
gTags.kom_laz_got1,
gTags.kom_laz_got2,
gTags.separator,
gTags.kom_sbrosawarii,
}},
{ "UDEFINED" ,new gTags [] {
gTags.separator,
gTags.gotownost,
gTags.separator,
gTags.nomer,
gTags.separator,
gTags.razreshenie,
}},
{ "��������" ,new gTags [] {
gTags.separator,
gTags.kom_barlew_nazad,
gTags.wyhd_barlew_nazad,
gTags.separator,
gTags.kom_barlew_wper_d,
gTags.wyhd_barlew_wper_d,
gTags.separator,
gTags.kom_barpraw_nazad,
gTags.wyhd_barpraw_nazad,
gTags.separator,
gTags.kom_barpraw_wper_d,
gTags.wyhd_barpraw_wper_d,
gTags.separator,
gTags.kom_klbarlew,
gTags.wyhd_klbarlew,
gTags.separator,
gTags.kom_klbarpraw,
gTags.wyhd_klbarpraw,
gTags.separator,
gTags.kom_nasotkgaza,
gTags.wyhd_nasotkgaza,
gTags.separator,
gTags.kom_barlew_stop,
gTags.kom_barpraw_stop,
gTags.separator,
gTags.ust_barlew_skor,
gTags.ust_barpraw_skor,
}},
{ "��������" ,new gTags [] {
gTags.separator,
gTags.kom_dozlew_nazad,
gTags.wyhd_dozlew_nazad,
gTags.separator,
gTags.kom_dozlew_wper,
gTags.wyhd_dozlew_wper,
gTags.separator,
gTags.kom_dozpraw_nazad,
gTags.wyhd_dozpraw_nazad,
gTags.separator,
gTags.kom_dozpraw_wper,
gTags.wyhd_dozpraw_wper,
gTags.separator,
gTags.kom_dozlew_stop,
gTags.kom_dozpraw_stop,
gTags.separator,
gTags.ust_dozlew_skor,
gTags.ust_dozlew_wremq,
gTags.separator,
gTags.ust_dozpraw_skor,
gTags.ust_dozpraw_wremq,
}},
{ "���������" ,new gTags [] {
gTags.separator,
gTags.kom_tolklew_nazad,
gTags.wyhd_tolklew_nazad,
gTags.separator,
gTags.kom_tolklew_wper_d,
gTags.wyhd_tolklew_wper_d,
gTags.separator,
gTags.kom_tolkpraw_nazad,
gTags.wyhd_tolkpraw_nazad,
gTags.separator,
gTags.kom_tolkpraw_wper_d,
gTags.wyhd_tolkpraw_wper_d,
gTags.separator,
gTags.ust_tolklew_rasst,
gTags.ust_tolklew_skor,
gTags.separator,
gTags.ust_tolkpraw_rasst,
gTags.ust_tolkpraw_skor,
}},
{ "���������������������" ,new gTags [] {
gTags.separator,
gTags.kom_tp_pauza,
gTags.wyhd_tp_pauza,
gTags.kom_tp_pauzaposleraskladki,
gTags.wyhd_tp_pauzaposleraskladki,
gTags.separator,
gTags.kom_tp_process,
gTags.wyhd_tp_process,
gTags.separator,
gTags.usttp_barlew_skor,
gTags.usttp_barlew_skorrask,
gTags.separator,
gTags.usttp_barpraw_skor,
gTags.usttp_barpraw_skorrask,
gTags.separator,
gTags.kom_tp_prer,
gTags.kom_tp_stop,
gTags.usttp_barlew_koorpusk,
gTags.usttp_barlew_koorstop,
gTags.separator,
gTags.usttp_barpraw_koorpusk,
gTags.usttp_barpraw_koorstop,
gTags.usttp_dozlew_skor,
gTags.usttp_dozlew_wremq,
gTags.separator,
gTags.usttp_dozpraw_skor,
gTags.usttp_dozpraw_wremq,
gTags.usttp_karlew_rasst1,
gTags.usttp_karlew_rasst2,
gTags.separator,
gTags.usttp_karlew_rasst3,
gTags.usttp_karlew_rasst4,
gTags.usttp_karlew_rasst5,
gTags.usttp_karlew_skor,
gTags.separator,
gTags.usttp_karpraw_rasst1,
gTags.usttp_karpraw_rasst2,
gTags.usttp_karpraw_rasst3,
gTags.usttp_karpraw_rasst4,
gTags.separator,
gTags.usttp_karpraw_rasst5,
gTags.usttp_karpraw_skor,
gTags.usttp_pauza1,
gTags.usttp_pauza2,
gTags.separator,
gTags.usttp_tolklew_rasst,
gTags.usttp_tolklew_skor,
gTags.usttp_tolkpraw_rasst,
gTags.usttp_tolkpraw_skor,
gTags.separator,
gTags.usttp_tolschsloq1,
gTags.wyhd_tp_sloj_rab1,
gTags.usttp_tolschsloq2,
gTags.wyhd_tp_sloj_rab2,
gTags.separator,
gTags.wyhd_tp_sloj_rab3,
}},
};
    public string get_by_name(string str) {
    switch (str){case "am_termopara1":
   return gets_am_termopara1();
case "am_dif_datch_rash":
   return gets_am_dif_datch_rash();
case "am_dawl_lew_fil_tr":
   return gets_am_dawl_lew_fil_tr();
case "am_dawl_praw_fil_tr":
   return gets_am_dawl_praw_fil_tr();
case "am_linejka":
   return gets_am_linejka();
case "am_tjen1_tek_moschn":
   return gets_am_tjen1_tek_moschn();
case "am_kar_lew_tek_poz":
   return gets_am_kar_lew_tek_poz();
case "am_stol_tek_poz":
   return gets_am_stol_tek_poz();
case "am_laz1_temp1":
   return gets_am_laz1_temp1();
case "am_laz1_temp2":
   return gets_am_laz1_temp2();
case "am_laz1_temp3":
   return gets_am_laz1_temp3();
case "am_laz2_temp1":
   return gets_am_laz2_temp1();
case "am_laz2_temp2":
   return gets_am_laz2_temp2();
case "am_laz2_temp3":
   return gets_am_laz2_temp3();
case "am_datch_kisl1":
   return gets_am_datch_kisl1();
case "am_datch_kisl2":
   return gets_am_datch_kisl2();
case "am_kar_praw_tek_poz":
   return gets_am_kar_praw_tek_poz();
case "am_dawl_w_kamere":
   return gets_am_dawl_w_kamere();
case "am_ohl_skan1":
   return gets_am_ohl_skan1();
case "am_ohl_skan2":
   return gets_am_ohl_skan2();
case "nomer":
   return gets_nomer();
case "am_dawl_w_kamere_dubl_r":
   return gets_am_dawl_w_kamere_dubl_r();
case "am_oxik":
   return gets_am_oxik();
case "dm_stol_abs_domgot":
   return gets_dm_stol_abs_domgot();
case "dm_laz1_prot1":
   return gets_dm_laz1_prot1();
case "dm_laz1_prot2":
   return gets_dm_laz1_prot2();
case "dm_laz1_prot3":
   return gets_dm_laz1_prot3();
case "dm_laz2_prot1":
   return gets_dm_laz2_prot1();
case "dm_laz2_prot2":
   return gets_dm_laz2_prot2();
case "dm_laz2_prot3":
   return gets_dm_laz2_prot3();
case "dm_karpraw_konc":
   return gets_dm_karpraw_konc();
case "dm_karlew_konc":
   return gets_dm_karlew_konc();
case "razreshenie":
   return gets_razreshenie();
case "gotownost":
   return gets_gotownost();
case "ind_skan1_ohl":
   return gets_ind_skan1_ohl();
case "ind_skan2_ohl":
   return gets_ind_skan2_ohl();
case "ind_laz1_ohl":
   return gets_ind_laz1_ohl();
case "ind_laz2_ohl":
   return gets_ind_laz2_ohl();
case "ind_kislorod":
   return gets_ind_kislorod();
case "ind_dawlkam":
   return gets_ind_dawlkam();
case "ust_stol_abs_poz":
   return gets_ust_stol_abs_poz();
case "ust_stol_skor":
   return gets_ust_stol_skor();
case "ust_stol_otn_rasst":
   return gets_ust_stol_otn_rasst();
case "ust_tjen1_moschn":
   return gets_ust_tjen1_moschn();
case "ust_tjen2_moschn":
   return gets_ust_tjen2_moschn();
case "ust_tjen3_moschn":
   return gets_ust_tjen3_moschn();
case "ust_tjen1_temp":
   return gets_ust_tjen1_temp();
case "ust_tjen2_temp":
   return gets_ust_tjen2_temp();
case "ust_tjen3_temp":
   return gets_ust_tjen3_temp();
case "ust_karlew_skor":
   return gets_ust_karlew_skor();
case "ust_karlew_otn_rast":
   return gets_ust_karlew_otn_rast();
case "ust_karlew_abs_poz":
   return gets_ust_karlew_abs_poz();
case "ust_karpraw_skor":
   return gets_ust_karpraw_skor();
case "ust_karpraw_otn_rast":
   return gets_ust_karpraw_otn_rast();
case "ust_karpraw_abs_poz":
   return gets_ust_karpraw_abs_poz();
case "ust_barpraw_skor":
   return gets_ust_barpraw_skor();
case "ust_barlew_skor":
   return gets_ust_barlew_skor();
case "ust_dozlew_wremq":
   return gets_ust_dozlew_wremq();
case "ust_dozpraw_wremq":
   return gets_ust_dozpraw_wremq();
case "ust_tolklew_rasst":
   return gets_ust_tolklew_rasst();
case "ust_tolkpraw_rasst":
   return gets_ust_tolkpraw_rasst();
case "ust_dozpraw_skor":
   return gets_ust_dozpraw_skor();
case "ust_dozlew_skor":
   return gets_ust_dozlew_skor();
case "ust_tolklew_skor":
   return gets_ust_tolklew_skor();
case "ust_tolkpraw_skor":
   return gets_ust_tolkpraw_skor();
case "wyhd_stol_abs":
   return gets_wyhd_stol_abs();
case "wyhd_tjen1_pit":
   return gets_wyhd_tjen1_pit();
case "wyhd_stol_otn_wniz":
   return gets_wyhd_stol_otn_wniz();
case "wyhd_stol_otn_wwerh":
   return gets_wyhd_stol_otn_wwerh();
case "wyhd_laz_pit1":
   return gets_wyhd_laz_pit1();
case "wyhd_pitchil1":
   return gets_wyhd_pitchil1();
case "wyhd_pitchil2":
   return gets_wyhd_pitchil2();
case "wyhd_pitmps":
   return gets_wyhd_pitmps();
case "wyhd_pitrec":
   return gets_wyhd_pitrec();
case "wyhd_kv1":
   return gets_wyhd_kv1();
case "wyhd_kv2":
   return gets_wyhd_kv2();
case "wyhd_kje9":
   return gets_wyhd_kje9();
case "wyhd_kje10":
   return gets_wyhd_kje10();
case "wyhd_karpraw_abs":
   return gets_wyhd_karpraw_abs();
case "wyhd_karlew_abs":
   return gets_wyhd_karlew_abs();
case "wyhd_dozpraw_wper":
   return gets_wyhd_dozpraw_wper();
case "wyhd_dozlew_wper":
   return gets_wyhd_dozlew_wper();
case "wyhd_dozpraw_nazad":
   return gets_wyhd_dozpraw_nazad();
case "wyhd_dozlew_nazad":
   return gets_wyhd_dozlew_nazad();
case "wyhd_stol_peresch_t":
   return gets_wyhd_stol_peresch_t();
case "wyhd_barlew_wper_d":
   return gets_wyhd_barlew_wper_d();
case "wyhd_barpraw_wper_d":
   return gets_wyhd_barpraw_wper_d();
case "wyhd_barlew_nazad":
   return gets_wyhd_barlew_nazad();
case "wyhd_barpraw_nazad":
   return gets_wyhd_barpraw_nazad();
case "wyhd_tolklew_wper_d":
   return gets_wyhd_tolklew_wper_d();
case "wyhd_tolkpraw_wper_d":
   return gets_wyhd_tolkpraw_wper_d();
case "wyhd_tolklew_nazad":
   return gets_wyhd_tolklew_nazad();
case "wyhd_tolkpraw_nazad":
   return gets_wyhd_tolkpraw_nazad();
case "wyhd_karpraw_otn_wper_d":
   return gets_wyhd_karpraw_otn_wper_d();
case "wyhd_karpraw_otn_nazad":
   return gets_wyhd_karpraw_otn_nazad();
case "wyhd_karlew_otn_wper_d":
   return gets_wyhd_karlew_otn_wper_d();
case "wyhd_karlew_otn_nazad":
   return gets_wyhd_karlew_otn_nazad();
case "wyhd_klbarlew":
   return gets_wyhd_klbarlew();
case "wyhd_klbarpraw":
   return gets_wyhd_klbarpraw();
case "wyhd_nasotkgaza":
   return gets_wyhd_nasotkgaza();
case "wyhd_tp_sloj_rab1":
   return gets_wyhd_tp_sloj_rab1();
case "wyhd_tp_process":
   return gets_wyhd_tp_process();
case "wyhd_laz_pit2":
   return gets_wyhd_laz_pit2();
case "wyhd_tp_sloj_rab2":
   return gets_wyhd_tp_sloj_rab2();
case "wyhd_tp_sloj_rab3":
   return gets_wyhd_tp_sloj_rab3();
case "wyhd_blokirowki":
   return gets_wyhd_blokirowki();
case "wyhd_tp_pauza":
   return gets_wyhd_tp_pauza();
case "wyhd_klnapgaza":
   return gets_wyhd_klnapgaza();
case "wyhd_tp_pauzaposleraskladki":
   return gets_wyhd_tp_pauzaposleraskladki();
case "kom_stol_abs":
   return gets_kom_stol_abs();
case "kom_tp_prer":
   return gets_kom_tp_prer();
case "kom_stol_stop":
   return gets_kom_stol_stop();
case "kom_stol_ustnulq":
   return gets_kom_stol_ustnulq();
case "kom_stol_otn_wniz":
   return gets_kom_stol_otn_wniz();
case "kom_stol_otn_wwerh":
   return gets_kom_stol_otn_wwerh();
case "kom_stol_obnulit_linejku":
   return gets_kom_stol_obnulit_linejku();
case "kom_tjen1":
   return gets_kom_tjen1();
case "kom_tp_process":
   return gets_kom_tp_process();
case "kom_stol_peresch_t":
   return gets_kom_stol_peresch_t();
case "kom_laz_pit1":
   return gets_kom_laz_pit1();
case "kom_laz_got1":
   return gets_kom_laz_got1();
case "kom_pitchil1":
   return gets_kom_pitchil1();
case "kom_pitchil2":
   return gets_kom_pitchil2();
case "kom_pitrec":
   return gets_kom_pitrec();
case "kom_pitmps":
   return gets_kom_pitmps();
case "kom_karlew_otn_wper_d":
   return gets_kom_karlew_otn_wper_d();
case "kom_karlew_otn_nazad":
   return gets_kom_karlew_otn_nazad();
case "kom_karpraw_otn_wper_d":
   return gets_kom_karpraw_otn_wper_d();
case "kom_karpraw_otn_nazad":
   return gets_kom_karpraw_otn_nazad();
case "kom_barpraw_wper_d":
   return gets_kom_barpraw_wper_d();
case "kom_barpraw_nazad":
   return gets_kom_barpraw_nazad();
case "kom_barlew_wper_d":
   return gets_kom_barlew_wper_d();
case "kom_barlew_nazad":
   return gets_kom_barlew_nazad();
case "kom_dozlew_wper":
   return gets_kom_dozlew_wper();
case "kom_dozpraw_wper":
   return gets_kom_dozpraw_wper();
case "kom_tolklew_wper_d":
   return gets_kom_tolklew_wper_d();
case "kom_tolklew_nazad":
   return gets_kom_tolklew_nazad();
case "kom_tolkpraw_wper_d":
   return gets_kom_tolkpraw_wper_d();
case "kom_tolkpraw_nazad":
   return gets_kom_tolkpraw_nazad();
case "kom_dozlew_nazad":
   return gets_kom_dozlew_nazad();
case "kom_dozpraw_nazad":
   return gets_kom_dozpraw_nazad();
case "kom_kje9_ohl_skan1":
   return gets_kom_kje9_ohl_skan1();
case "kom_kje10_ohl_skan2":
   return gets_kom_kje10_ohl_skan2();
case "kom_kv1":
   return gets_kom_kv1();
case "kom_kv2":
   return gets_kom_kv2();
case "kom_klbarlew":
   return gets_kom_klbarlew();
case "kom_klbarpraw":
   return gets_kom_klbarpraw();
case "kom_nasotkgaza":
   return gets_kom_nasotkgaza();
case "kom_barlew_stop":
   return gets_kom_barlew_stop();
case "kom_barpraw_stop":
   return gets_kom_barpraw_stop();
case "kom_dozlew_stop":
   return gets_kom_dozlew_stop();
case "kom_dozpraw_stop":
   return gets_kom_dozpraw_stop();
case "kom_karlew_stop":
   return gets_kom_karlew_stop();
case "kom_karpraw_stop":
   return gets_kom_karpraw_stop();
case "kom_laz_got2":
   return gets_kom_laz_got2();
case "kom_laz_pit2":
   return gets_kom_laz_pit2();
case "kom_sbrosawarii":
   return gets_kom_sbrosawarii();
case "kom_blokirowki":
   return gets_kom_blokirowki();
case "kom_tp_pauza":
   return gets_kom_tp_pauza();
case "kom_klnapgaza":
   return gets_kom_klnapgaza();
case "kom_tp_stop":
   return gets_kom_tp_stop();
case "kom_tp_pauzaposleraskladki":
   return gets_kom_tp_pauzaposleraskladki();
case "usttp_karpraw_skor":
   return gets_usttp_karpraw_skor();
case "usttp_karlew_skor":
   return gets_usttp_karlew_skor();
case "usttp_tolkpraw_rasst":
   return gets_usttp_tolkpraw_rasst();
case "usttp_tolkpraw_skor":
   return gets_usttp_tolkpraw_skor();
case "usttp_karpraw_rasst2":
   return gets_usttp_karpraw_rasst2();
case "usttp_dozpraw_wremq":
   return gets_usttp_dozpraw_wremq();
case "usttp_dozpraw_skor":
   return gets_usttp_dozpraw_skor();
case "usttp_karpraw_rasst3":
   return gets_usttp_karpraw_rasst3();
case "usttp_karpraw_rasst4":
   return gets_usttp_karpraw_rasst4();
case "usttp_barpraw_skor":
   return gets_usttp_barpraw_skor();
case "usttp_karpraw_rasst5":
   return gets_usttp_karpraw_rasst5();
case "usttp_karlew_rasst1":
   return gets_usttp_karlew_rasst1();
case "usttp_tolklew_rasst":
   return gets_usttp_tolklew_rasst();
case "usttp_tolklew_skor":
   return gets_usttp_tolklew_skor();
case "usttp_karlew_rasst2":
   return gets_usttp_karlew_rasst2();
case "usttp_dozlew_wremq":
   return gets_usttp_dozlew_wremq();
case "usttp_dozlew_skor":
   return gets_usttp_dozlew_skor();
case "usttp_karlew_rasst3":
   return gets_usttp_karlew_rasst3();
case "usttp_karlew_rasst4":
   return gets_usttp_karlew_rasst4();
case "usttp_barlew_skor":
   return gets_usttp_barlew_skor();
case "usttp_karlew_rasst5":
   return gets_usttp_karlew_rasst5();
case "usttp_tolschsloq2":
   return gets_usttp_tolschsloq2();
case "usttp_pauza1":
   return gets_usttp_pauza1();
case "usttp_tolschsloq1":
   return gets_usttp_tolschsloq1();
case "usttp_pauza2":
   return gets_usttp_pauza2();
case "usttp_karpraw_rasst1":
   return gets_usttp_karpraw_rasst1();
case "usttp_barpraw_skorrask":
   return gets_usttp_barpraw_skorrask();
case "usttp_barpraw_koorpusk":
   return gets_usttp_barpraw_koorpusk();
case "usttp_barpraw_koorstop":
   return gets_usttp_barpraw_koorstop();
case "usttp_barlew_skorrask":
   return gets_usttp_barlew_skorrask();
case "usttp_barlew_koorpusk":
   return gets_usttp_barlew_koorpusk();
case "usttp_barlew_koorstop":
   return gets_usttp_barlew_koorstop();
default: 
   return "NAN";
} 
 }
    public bool set_by_name(string str, string val) {
    switch (str){case "am_termopara1":
   return sets_am_termopara1(val);
case "am_dif_datch_rash":
   return sets_am_dif_datch_rash(val);
case "am_dawl_lew_fil_tr":
   return sets_am_dawl_lew_fil_tr(val);
case "am_dawl_praw_fil_tr":
   return sets_am_dawl_praw_fil_tr(val);
case "am_linejka":
   return sets_am_linejka(val);
case "am_tjen1_tek_moschn":
   return sets_am_tjen1_tek_moschn(val);
case "am_kar_lew_tek_poz":
   return sets_am_kar_lew_tek_poz(val);
case "am_stol_tek_poz":
   return sets_am_stol_tek_poz(val);
case "am_laz1_temp1":
   return sets_am_laz1_temp1(val);
case "am_laz1_temp2":
   return sets_am_laz1_temp2(val);
case "am_laz1_temp3":
   return sets_am_laz1_temp3(val);
case "am_laz2_temp1":
   return sets_am_laz2_temp1(val);
case "am_laz2_temp2":
   return sets_am_laz2_temp2(val);
case "am_laz2_temp3":
   return sets_am_laz2_temp3(val);
case "am_datch_kisl1":
   return sets_am_datch_kisl1(val);
case "am_datch_kisl2":
   return sets_am_datch_kisl2(val);
case "am_kar_praw_tek_poz":
   return sets_am_kar_praw_tek_poz(val);
case "am_dawl_w_kamere":
   return sets_am_dawl_w_kamere(val);
case "am_ohl_skan1":
   return sets_am_ohl_skan1(val);
case "am_ohl_skan2":
   return sets_am_ohl_skan2(val);
case "nomer":
   return sets_nomer(val);
case "am_dawl_w_kamere_dubl_r":
   return sets_am_dawl_w_kamere_dubl_r(val);
case "am_oxik":
   return sets_am_oxik(val);
case "dm_stol_abs_domgot":
   return sets_dm_stol_abs_domgot(val);
case "dm_laz1_prot1":
   return sets_dm_laz1_prot1(val);
case "dm_laz1_prot2":
   return sets_dm_laz1_prot2(val);
case "dm_laz1_prot3":
   return sets_dm_laz1_prot3(val);
case "dm_laz2_prot1":
   return sets_dm_laz2_prot1(val);
case "dm_laz2_prot2":
   return sets_dm_laz2_prot2(val);
case "dm_laz2_prot3":
   return sets_dm_laz2_prot3(val);
case "dm_karpraw_konc":
   return sets_dm_karpraw_konc(val);
case "dm_karlew_konc":
   return sets_dm_karlew_konc(val);
case "razreshenie":
   return sets_razreshenie(val);
case "gotownost":
   return sets_gotownost(val);
case "ind_skan1_ohl":
   return sets_ind_skan1_ohl(val);
case "ind_skan2_ohl":
   return sets_ind_skan2_ohl(val);
case "ind_laz1_ohl":
   return sets_ind_laz1_ohl(val);
case "ind_laz2_ohl":
   return sets_ind_laz2_ohl(val);
case "ind_kislorod":
   return sets_ind_kislorod(val);
case "ind_dawlkam":
   return sets_ind_dawlkam(val);
case "ust_stol_abs_poz":
   return sets_ust_stol_abs_poz(val);
case "ust_stol_skor":
   return sets_ust_stol_skor(val);
case "ust_stol_otn_rasst":
   return sets_ust_stol_otn_rasst(val);
case "ust_tjen1_moschn":
   return sets_ust_tjen1_moschn(val);
case "ust_tjen2_moschn":
   return sets_ust_tjen2_moschn(val);
case "ust_tjen3_moschn":
   return sets_ust_tjen3_moschn(val);
case "ust_tjen1_temp":
   return sets_ust_tjen1_temp(val);
case "ust_tjen2_temp":
   return sets_ust_tjen2_temp(val);
case "ust_tjen3_temp":
   return sets_ust_tjen3_temp(val);
case "ust_karlew_skor":
   return sets_ust_karlew_skor(val);
case "ust_karlew_otn_rast":
   return sets_ust_karlew_otn_rast(val);
case "ust_karlew_abs_poz":
   return sets_ust_karlew_abs_poz(val);
case "ust_karpraw_skor":
   return sets_ust_karpraw_skor(val);
case "ust_karpraw_otn_rast":
   return sets_ust_karpraw_otn_rast(val);
case "ust_karpraw_abs_poz":
   return sets_ust_karpraw_abs_poz(val);
case "ust_barpraw_skor":
   return sets_ust_barpraw_skor(val);
case "ust_barlew_skor":
   return sets_ust_barlew_skor(val);
case "ust_dozlew_wremq":
   return sets_ust_dozlew_wremq(val);
case "ust_dozpraw_wremq":
   return sets_ust_dozpraw_wremq(val);
case "ust_tolklew_rasst":
   return sets_ust_tolklew_rasst(val);
case "ust_tolkpraw_rasst":
   return sets_ust_tolkpraw_rasst(val);
case "ust_dozpraw_skor":
   return sets_ust_dozpraw_skor(val);
case "ust_dozlew_skor":
   return sets_ust_dozlew_skor(val);
case "ust_tolklew_skor":
   return sets_ust_tolklew_skor(val);
case "ust_tolkpraw_skor":
   return sets_ust_tolkpraw_skor(val);
case "wyhd_stol_abs":
   return sets_wyhd_stol_abs(val);
case "wyhd_tjen1_pit":
   return sets_wyhd_tjen1_pit(val);
case "wyhd_stol_otn_wniz":
   return sets_wyhd_stol_otn_wniz(val);
case "wyhd_stol_otn_wwerh":
   return sets_wyhd_stol_otn_wwerh(val);
case "wyhd_laz_pit1":
   return sets_wyhd_laz_pit1(val);
case "wyhd_pitchil1":
   return sets_wyhd_pitchil1(val);
case "wyhd_pitchil2":
   return sets_wyhd_pitchil2(val);
case "wyhd_pitmps":
   return sets_wyhd_pitmps(val);
case "wyhd_pitrec":
   return sets_wyhd_pitrec(val);
case "wyhd_kv1":
   return sets_wyhd_kv1(val);
case "wyhd_kv2":
   return sets_wyhd_kv2(val);
case "wyhd_kje9":
   return sets_wyhd_kje9(val);
case "wyhd_kje10":
   return sets_wyhd_kje10(val);
case "wyhd_karpraw_abs":
   return sets_wyhd_karpraw_abs(val);
case "wyhd_karlew_abs":
   return sets_wyhd_karlew_abs(val);
case "wyhd_dozpraw_wper":
   return sets_wyhd_dozpraw_wper(val);
case "wyhd_dozlew_wper":
   return sets_wyhd_dozlew_wper(val);
case "wyhd_dozpraw_nazad":
   return sets_wyhd_dozpraw_nazad(val);
case "wyhd_dozlew_nazad":
   return sets_wyhd_dozlew_nazad(val);
case "wyhd_stol_peresch_t":
   return sets_wyhd_stol_peresch_t(val);
case "wyhd_barlew_wper_d":
   return sets_wyhd_barlew_wper_d(val);
case "wyhd_barpraw_wper_d":
   return sets_wyhd_barpraw_wper_d(val);
case "wyhd_barlew_nazad":
   return sets_wyhd_barlew_nazad(val);
case "wyhd_barpraw_nazad":
   return sets_wyhd_barpraw_nazad(val);
case "wyhd_tolklew_wper_d":
   return sets_wyhd_tolklew_wper_d(val);
case "wyhd_tolkpraw_wper_d":
   return sets_wyhd_tolkpraw_wper_d(val);
case "wyhd_tolklew_nazad":
   return sets_wyhd_tolklew_nazad(val);
case "wyhd_tolkpraw_nazad":
   return sets_wyhd_tolkpraw_nazad(val);
case "wyhd_karpraw_otn_wper_d":
   return sets_wyhd_karpraw_otn_wper_d(val);
case "wyhd_karpraw_otn_nazad":
   return sets_wyhd_karpraw_otn_nazad(val);
case "wyhd_karlew_otn_wper_d":
   return sets_wyhd_karlew_otn_wper_d(val);
case "wyhd_karlew_otn_nazad":
   return sets_wyhd_karlew_otn_nazad(val);
case "wyhd_klbarlew":
   return sets_wyhd_klbarlew(val);
case "wyhd_klbarpraw":
   return sets_wyhd_klbarpraw(val);
case "wyhd_nasotkgaza":
   return sets_wyhd_nasotkgaza(val);
case "wyhd_tp_sloj_rab1":
   return sets_wyhd_tp_sloj_rab1(val);
case "wyhd_tp_process":
   return sets_wyhd_tp_process(val);
case "wyhd_laz_pit2":
   return sets_wyhd_laz_pit2(val);
case "wyhd_tp_sloj_rab2":
   return sets_wyhd_tp_sloj_rab2(val);
case "wyhd_tp_sloj_rab3":
   return sets_wyhd_tp_sloj_rab3(val);
case "wyhd_blokirowki":
   return sets_wyhd_blokirowki(val);
case "wyhd_tp_pauza":
   return sets_wyhd_tp_pauza(val);
case "wyhd_klnapgaza":
   return sets_wyhd_klnapgaza(val);
case "wyhd_tp_pauzaposleraskladki":
   return sets_wyhd_tp_pauzaposleraskladki(val);
case "kom_stol_abs":
   return sets_kom_stol_abs(val);
case "kom_tp_prer":
   return sets_kom_tp_prer(val);
case "kom_stol_stop":
   return sets_kom_stol_stop(val);
case "kom_stol_ustnulq":
   return sets_kom_stol_ustnulq(val);
case "kom_stol_otn_wniz":
   return sets_kom_stol_otn_wniz(val);
case "kom_stol_otn_wwerh":
   return sets_kom_stol_otn_wwerh(val);
case "kom_stol_obnulit_linejku":
   return sets_kom_stol_obnulit_linejku(val);
case "kom_tjen1":
   return sets_kom_tjen1(val);
case "kom_tp_process":
   return sets_kom_tp_process(val);
case "kom_stol_peresch_t":
   return sets_kom_stol_peresch_t(val);
case "kom_laz_pit1":
   return sets_kom_laz_pit1(val);
case "kom_laz_got1":
   return sets_kom_laz_got1(val);
case "kom_pitchil1":
   return sets_kom_pitchil1(val);
case "kom_pitchil2":
   return sets_kom_pitchil2(val);
case "kom_pitrec":
   return sets_kom_pitrec(val);
case "kom_pitmps":
   return sets_kom_pitmps(val);
case "kom_karlew_otn_wper_d":
   return sets_kom_karlew_otn_wper_d(val);
case "kom_karlew_otn_nazad":
   return sets_kom_karlew_otn_nazad(val);
case "kom_karpraw_otn_wper_d":
   return sets_kom_karpraw_otn_wper_d(val);
case "kom_karpraw_otn_nazad":
   return sets_kom_karpraw_otn_nazad(val);
case "kom_barpraw_wper_d":
   return sets_kom_barpraw_wper_d(val);
case "kom_barpraw_nazad":
   return sets_kom_barpraw_nazad(val);
case "kom_barlew_wper_d":
   return sets_kom_barlew_wper_d(val);
case "kom_barlew_nazad":
   return sets_kom_barlew_nazad(val);
case "kom_dozlew_wper":
   return sets_kom_dozlew_wper(val);
case "kom_dozpraw_wper":
   return sets_kom_dozpraw_wper(val);
case "kom_tolklew_wper_d":
   return sets_kom_tolklew_wper_d(val);
case "kom_tolklew_nazad":
   return sets_kom_tolklew_nazad(val);
case "kom_tolkpraw_wper_d":
   return sets_kom_tolkpraw_wper_d(val);
case "kom_tolkpraw_nazad":
   return sets_kom_tolkpraw_nazad(val);
case "kom_dozlew_nazad":
   return sets_kom_dozlew_nazad(val);
case "kom_dozpraw_nazad":
   return sets_kom_dozpraw_nazad(val);
case "kom_kje9_ohl_skan1":
   return sets_kom_kje9_ohl_skan1(val);
case "kom_kje10_ohl_skan2":
   return sets_kom_kje10_ohl_skan2(val);
case "kom_kv1":
   return sets_kom_kv1(val);
case "kom_kv2":
   return sets_kom_kv2(val);
case "kom_klbarlew":
   return sets_kom_klbarlew(val);
case "kom_klbarpraw":
   return sets_kom_klbarpraw(val);
case "kom_nasotkgaza":
   return sets_kom_nasotkgaza(val);
case "kom_barlew_stop":
   return sets_kom_barlew_stop(val);
case "kom_barpraw_stop":
   return sets_kom_barpraw_stop(val);
case "kom_dozlew_stop":
   return sets_kom_dozlew_stop(val);
case "kom_dozpraw_stop":
   return sets_kom_dozpraw_stop(val);
case "kom_karlew_stop":
   return sets_kom_karlew_stop(val);
case "kom_karpraw_stop":
   return sets_kom_karpraw_stop(val);
case "kom_laz_got2":
   return sets_kom_laz_got2(val);
case "kom_laz_pit2":
   return sets_kom_laz_pit2(val);
case "kom_sbrosawarii":
   return sets_kom_sbrosawarii(val);
case "kom_blokirowki":
   return sets_kom_blokirowki(val);
case "kom_tp_pauza":
   return sets_kom_tp_pauza(val);
case "kom_klnapgaza":
   return sets_kom_klnapgaza(val);
case "kom_tp_stop":
   return sets_kom_tp_stop(val);
case "kom_tp_pauzaposleraskladki":
   return sets_kom_tp_pauzaposleraskladki(val);
case "usttp_karpraw_skor":
   return sets_usttp_karpraw_skor(val);
case "usttp_karlew_skor":
   return sets_usttp_karlew_skor(val);
case "usttp_tolkpraw_rasst":
   return sets_usttp_tolkpraw_rasst(val);
case "usttp_tolkpraw_skor":
   return sets_usttp_tolkpraw_skor(val);
case "usttp_karpraw_rasst2":
   return sets_usttp_karpraw_rasst2(val);
case "usttp_dozpraw_wremq":
   return sets_usttp_dozpraw_wremq(val);
case "usttp_dozpraw_skor":
   return sets_usttp_dozpraw_skor(val);
case "usttp_karpraw_rasst3":
   return sets_usttp_karpraw_rasst3(val);
case "usttp_karpraw_rasst4":
   return sets_usttp_karpraw_rasst4(val);
case "usttp_barpraw_skor":
   return sets_usttp_barpraw_skor(val);
case "usttp_karpraw_rasst5":
   return sets_usttp_karpraw_rasst5(val);
case "usttp_karlew_rasst1":
   return sets_usttp_karlew_rasst1(val);
case "usttp_tolklew_rasst":
   return sets_usttp_tolklew_rasst(val);
case "usttp_tolklew_skor":
   return sets_usttp_tolklew_skor(val);
case "usttp_karlew_rasst2":
   return sets_usttp_karlew_rasst2(val);
case "usttp_dozlew_wremq":
   return sets_usttp_dozlew_wremq(val);
case "usttp_dozlew_skor":
   return sets_usttp_dozlew_skor(val);
case "usttp_karlew_rasst3":
   return sets_usttp_karlew_rasst3(val);
case "usttp_karlew_rasst4":
   return sets_usttp_karlew_rasst4(val);
case "usttp_barlew_skor":
   return sets_usttp_barlew_skor(val);
case "usttp_karlew_rasst5":
   return sets_usttp_karlew_rasst5(val);
case "usttp_tolschsloq2":
   return sets_usttp_tolschsloq2(val);
case "usttp_pauza1":
   return sets_usttp_pauza1(val);
case "usttp_tolschsloq1":
   return sets_usttp_tolschsloq1(val);
case "usttp_pauza2":
   return sets_usttp_pauza2(val);
case "usttp_karpraw_rasst1":
   return sets_usttp_karpraw_rasst1(val);
case "usttp_barpraw_skorrask":
   return sets_usttp_barpraw_skorrask(val);
case "usttp_barpraw_koorpusk":
   return sets_usttp_barpraw_koorpusk(val);
case "usttp_barpraw_koorstop":
   return sets_usttp_barpraw_koorstop(val);
case "usttp_barlew_skorrask":
   return sets_usttp_barlew_skorrask(val);
case "usttp_barlew_koorpusk":
   return sets_usttp_barlew_koorpusk(val);
case "usttp_barlew_koorstop":
   return sets_usttp_barlew_koorstop(val);
default: 
   return false;
} 
 }
    public string get_debug_by_name(string str) {
    switch (str){case "am_termopara1":
   return debug_name_am_termopara1();
case "am_dif_datch_rash":
   return debug_name_am_dif_datch_rash();
case "am_dawl_lew_fil_tr":
   return debug_name_am_dawl_lew_fil_tr();
case "am_dawl_praw_fil_tr":
   return debug_name_am_dawl_praw_fil_tr();
case "am_linejka":
   return debug_name_am_linejka();
case "am_tjen1_tek_moschn":
   return debug_name_am_tjen1_tek_moschn();
case "am_kar_lew_tek_poz":
   return debug_name_am_kar_lew_tek_poz();
case "am_stol_tek_poz":
   return debug_name_am_stol_tek_poz();
case "am_laz1_temp1":
   return debug_name_am_laz1_temp1();
case "am_laz1_temp2":
   return debug_name_am_laz1_temp2();
case "am_laz1_temp3":
   return debug_name_am_laz1_temp3();
case "am_laz2_temp1":
   return debug_name_am_laz2_temp1();
case "am_laz2_temp2":
   return debug_name_am_laz2_temp2();
case "am_laz2_temp3":
   return debug_name_am_laz2_temp3();
case "am_datch_kisl1":
   return debug_name_am_datch_kisl1();
case "am_datch_kisl2":
   return debug_name_am_datch_kisl2();
case "am_kar_praw_tek_poz":
   return debug_name_am_kar_praw_tek_poz();
case "am_dawl_w_kamere":
   return debug_name_am_dawl_w_kamere();
case "am_ohl_skan1":
   return debug_name_am_ohl_skan1();
case "am_ohl_skan2":
   return debug_name_am_ohl_skan2();
case "nomer":
   return debug_name_nomer();
case "am_dawl_w_kamere_dubl_r":
   return debug_name_am_dawl_w_kamere_dubl_r();
case "am_oxik":
   return debug_name_am_oxik();
case "dm_stol_abs_domgot":
   return debug_name_dm_stol_abs_domgot();
case "dm_laz1_prot1":
   return debug_name_dm_laz1_prot1();
case "dm_laz1_prot2":
   return debug_name_dm_laz1_prot2();
case "dm_laz1_prot3":
   return debug_name_dm_laz1_prot3();
case "dm_laz2_prot1":
   return debug_name_dm_laz2_prot1();
case "dm_laz2_prot2":
   return debug_name_dm_laz2_prot2();
case "dm_laz2_prot3":
   return debug_name_dm_laz2_prot3();
case "dm_karpraw_konc":
   return debug_name_dm_karpraw_konc();
case "dm_karlew_konc":
   return debug_name_dm_karlew_konc();
case "razreshenie":
   return debug_name_razreshenie();
case "gotownost":
   return debug_name_gotownost();
case "ind_skan1_ohl":
   return debug_name_ind_skan1_ohl();
case "ind_skan2_ohl":
   return debug_name_ind_skan2_ohl();
case "ind_laz1_ohl":
   return debug_name_ind_laz1_ohl();
case "ind_laz2_ohl":
   return debug_name_ind_laz2_ohl();
case "ind_kislorod":
   return debug_name_ind_kislorod();
case "ind_dawlkam":
   return debug_name_ind_dawlkam();
case "ust_stol_abs_poz":
   return debug_name_ust_stol_abs_poz();
case "ust_stol_skor":
   return debug_name_ust_stol_skor();
case "ust_stol_otn_rasst":
   return debug_name_ust_stol_otn_rasst();
case "ust_tjen1_moschn":
   return debug_name_ust_tjen1_moschn();
case "ust_tjen2_moschn":
   return debug_name_ust_tjen2_moschn();
case "ust_tjen3_moschn":
   return debug_name_ust_tjen3_moschn();
case "ust_tjen1_temp":
   return debug_name_ust_tjen1_temp();
case "ust_tjen2_temp":
   return debug_name_ust_tjen2_temp();
case "ust_tjen3_temp":
   return debug_name_ust_tjen3_temp();
case "ust_karlew_skor":
   return debug_name_ust_karlew_skor();
case "ust_karlew_otn_rast":
   return debug_name_ust_karlew_otn_rast();
case "ust_karlew_abs_poz":
   return debug_name_ust_karlew_abs_poz();
case "ust_karpraw_skor":
   return debug_name_ust_karpraw_skor();
case "ust_karpraw_otn_rast":
   return debug_name_ust_karpraw_otn_rast();
case "ust_karpraw_abs_poz":
   return debug_name_ust_karpraw_abs_poz();
case "ust_barpraw_skor":
   return debug_name_ust_barpraw_skor();
case "ust_barlew_skor":
   return debug_name_ust_barlew_skor();
case "ust_dozlew_wremq":
   return debug_name_ust_dozlew_wremq();
case "ust_dozpraw_wremq":
   return debug_name_ust_dozpraw_wremq();
case "ust_tolklew_rasst":
   return debug_name_ust_tolklew_rasst();
case "ust_tolkpraw_rasst":
   return debug_name_ust_tolkpraw_rasst();
case "ust_dozpraw_skor":
   return debug_name_ust_dozpraw_skor();
case "ust_dozlew_skor":
   return debug_name_ust_dozlew_skor();
case "ust_tolklew_skor":
   return debug_name_ust_tolklew_skor();
case "ust_tolkpraw_skor":
   return debug_name_ust_tolkpraw_skor();
case "wyhd_stol_abs":
   return debug_name_wyhd_stol_abs();
case "wyhd_tjen1_pit":
   return debug_name_wyhd_tjen1_pit();
case "wyhd_stol_otn_wniz":
   return debug_name_wyhd_stol_otn_wniz();
case "wyhd_stol_otn_wwerh":
   return debug_name_wyhd_stol_otn_wwerh();
case "wyhd_laz_pit1":
   return debug_name_wyhd_laz_pit1();
case "wyhd_pitchil1":
   return debug_name_wyhd_pitchil1();
case "wyhd_pitchil2":
   return debug_name_wyhd_pitchil2();
case "wyhd_pitmps":
   return debug_name_wyhd_pitmps();
case "wyhd_pitrec":
   return debug_name_wyhd_pitrec();
case "wyhd_kv1":
   return debug_name_wyhd_kv1();
case "wyhd_kv2":
   return debug_name_wyhd_kv2();
case "wyhd_kje9":
   return debug_name_wyhd_kje9();
case "wyhd_kje10":
   return debug_name_wyhd_kje10();
case "wyhd_karpraw_abs":
   return debug_name_wyhd_karpraw_abs();
case "wyhd_karlew_abs":
   return debug_name_wyhd_karlew_abs();
case "wyhd_dozpraw_wper":
   return debug_name_wyhd_dozpraw_wper();
case "wyhd_dozlew_wper":
   return debug_name_wyhd_dozlew_wper();
case "wyhd_dozpraw_nazad":
   return debug_name_wyhd_dozpraw_nazad();
case "wyhd_dozlew_nazad":
   return debug_name_wyhd_dozlew_nazad();
case "wyhd_stol_peresch_t":
   return debug_name_wyhd_stol_peresch_t();
case "wyhd_barlew_wper_d":
   return debug_name_wyhd_barlew_wper_d();
case "wyhd_barpraw_wper_d":
   return debug_name_wyhd_barpraw_wper_d();
case "wyhd_barlew_nazad":
   return debug_name_wyhd_barlew_nazad();
case "wyhd_barpraw_nazad":
   return debug_name_wyhd_barpraw_nazad();
case "wyhd_tolklew_wper_d":
   return debug_name_wyhd_tolklew_wper_d();
case "wyhd_tolkpraw_wper_d":
   return debug_name_wyhd_tolkpraw_wper_d();
case "wyhd_tolklew_nazad":
   return debug_name_wyhd_tolklew_nazad();
case "wyhd_tolkpraw_nazad":
   return debug_name_wyhd_tolkpraw_nazad();
case "wyhd_karpraw_otn_wper_d":
   return debug_name_wyhd_karpraw_otn_wper_d();
case "wyhd_karpraw_otn_nazad":
   return debug_name_wyhd_karpraw_otn_nazad();
case "wyhd_karlew_otn_wper_d":
   return debug_name_wyhd_karlew_otn_wper_d();
case "wyhd_karlew_otn_nazad":
   return debug_name_wyhd_karlew_otn_nazad();
case "wyhd_klbarlew":
   return debug_name_wyhd_klbarlew();
case "wyhd_klbarpraw":
   return debug_name_wyhd_klbarpraw();
case "wyhd_nasotkgaza":
   return debug_name_wyhd_nasotkgaza();
case "wyhd_tp_sloj_rab1":
   return debug_name_wyhd_tp_sloj_rab1();
case "wyhd_tp_process":
   return debug_name_wyhd_tp_process();
case "wyhd_laz_pit2":
   return debug_name_wyhd_laz_pit2();
case "wyhd_tp_sloj_rab2":
   return debug_name_wyhd_tp_sloj_rab2();
case "wyhd_tp_sloj_rab3":
   return debug_name_wyhd_tp_sloj_rab3();
case "wyhd_blokirowki":
   return debug_name_wyhd_blokirowki();
case "wyhd_tp_pauza":
   return debug_name_wyhd_tp_pauza();
case "wyhd_klnapgaza":
   return debug_name_wyhd_klnapgaza();
case "wyhd_tp_pauzaposleraskladki":
   return debug_name_wyhd_tp_pauzaposleraskladki();
case "kom_stol_abs":
   return debug_name_kom_stol_abs();
case "kom_tp_prer":
   return debug_name_kom_tp_prer();
case "kom_stol_stop":
   return debug_name_kom_stol_stop();
case "kom_stol_ustnulq":
   return debug_name_kom_stol_ustnulq();
case "kom_stol_otn_wniz":
   return debug_name_kom_stol_otn_wniz();
case "kom_stol_otn_wwerh":
   return debug_name_kom_stol_otn_wwerh();
case "kom_stol_obnulit_linejku":
   return debug_name_kom_stol_obnulit_linejku();
case "kom_tjen1":
   return debug_name_kom_tjen1();
case "kom_tp_process":
   return debug_name_kom_tp_process();
case "kom_stol_peresch_t":
   return debug_name_kom_stol_peresch_t();
case "kom_laz_pit1":
   return debug_name_kom_laz_pit1();
case "kom_laz_got1":
   return debug_name_kom_laz_got1();
case "kom_pitchil1":
   return debug_name_kom_pitchil1();
case "kom_pitchil2":
   return debug_name_kom_pitchil2();
case "kom_pitrec":
   return debug_name_kom_pitrec();
case "kom_pitmps":
   return debug_name_kom_pitmps();
case "kom_karlew_otn_wper_d":
   return debug_name_kom_karlew_otn_wper_d();
case "kom_karlew_otn_nazad":
   return debug_name_kom_karlew_otn_nazad();
case "kom_karpraw_otn_wper_d":
   return debug_name_kom_karpraw_otn_wper_d();
case "kom_karpraw_otn_nazad":
   return debug_name_kom_karpraw_otn_nazad();
case "kom_barpraw_wper_d":
   return debug_name_kom_barpraw_wper_d();
case "kom_barpraw_nazad":
   return debug_name_kom_barpraw_nazad();
case "kom_barlew_wper_d":
   return debug_name_kom_barlew_wper_d();
case "kom_barlew_nazad":
   return debug_name_kom_barlew_nazad();
case "kom_dozlew_wper":
   return debug_name_kom_dozlew_wper();
case "kom_dozpraw_wper":
   return debug_name_kom_dozpraw_wper();
case "kom_tolklew_wper_d":
   return debug_name_kom_tolklew_wper_d();
case "kom_tolklew_nazad":
   return debug_name_kom_tolklew_nazad();
case "kom_tolkpraw_wper_d":
   return debug_name_kom_tolkpraw_wper_d();
case "kom_tolkpraw_nazad":
   return debug_name_kom_tolkpraw_nazad();
case "kom_dozlew_nazad":
   return debug_name_kom_dozlew_nazad();
case "kom_dozpraw_nazad":
   return debug_name_kom_dozpraw_nazad();
case "kom_kje9_ohl_skan1":
   return debug_name_kom_kje9_ohl_skan1();
case "kom_kje10_ohl_skan2":
   return debug_name_kom_kje10_ohl_skan2();
case "kom_kv1":
   return debug_name_kom_kv1();
case "kom_kv2":
   return debug_name_kom_kv2();
case "kom_klbarlew":
   return debug_name_kom_klbarlew();
case "kom_klbarpraw":
   return debug_name_kom_klbarpraw();
case "kom_nasotkgaza":
   return debug_name_kom_nasotkgaza();
case "kom_barlew_stop":
   return debug_name_kom_barlew_stop();
case "kom_barpraw_stop":
   return debug_name_kom_barpraw_stop();
case "kom_dozlew_stop":
   return debug_name_kom_dozlew_stop();
case "kom_dozpraw_stop":
   return debug_name_kom_dozpraw_stop();
case "kom_karlew_stop":
   return debug_name_kom_karlew_stop();
case "kom_karpraw_stop":
   return debug_name_kom_karpraw_stop();
case "kom_laz_got2":
   return debug_name_kom_laz_got2();
case "kom_laz_pit2":
   return debug_name_kom_laz_pit2();
case "kom_sbrosawarii":
   return debug_name_kom_sbrosawarii();
case "kom_blokirowki":
   return debug_name_kom_blokirowki();
case "kom_tp_pauza":
   return debug_name_kom_tp_pauza();
case "kom_klnapgaza":
   return debug_name_kom_klnapgaza();
case "kom_tp_stop":
   return debug_name_kom_tp_stop();
case "kom_tp_pauzaposleraskladki":
   return debug_name_kom_tp_pauzaposleraskladki();
case "usttp_karpraw_skor":
   return debug_name_usttp_karpraw_skor();
case "usttp_karlew_skor":
   return debug_name_usttp_karlew_skor();
case "usttp_tolkpraw_rasst":
   return debug_name_usttp_tolkpraw_rasst();
case "usttp_tolkpraw_skor":
   return debug_name_usttp_tolkpraw_skor();
case "usttp_karpraw_rasst2":
   return debug_name_usttp_karpraw_rasst2();
case "usttp_dozpraw_wremq":
   return debug_name_usttp_dozpraw_wremq();
case "usttp_dozpraw_skor":
   return debug_name_usttp_dozpraw_skor();
case "usttp_karpraw_rasst3":
   return debug_name_usttp_karpraw_rasst3();
case "usttp_karpraw_rasst4":
   return debug_name_usttp_karpraw_rasst4();
case "usttp_barpraw_skor":
   return debug_name_usttp_barpraw_skor();
case "usttp_karpraw_rasst5":
   return debug_name_usttp_karpraw_rasst5();
case "usttp_karlew_rasst1":
   return debug_name_usttp_karlew_rasst1();
case "usttp_tolklew_rasst":
   return debug_name_usttp_tolklew_rasst();
case "usttp_tolklew_skor":
   return debug_name_usttp_tolklew_skor();
case "usttp_karlew_rasst2":
   return debug_name_usttp_karlew_rasst2();
case "usttp_dozlew_wremq":
   return debug_name_usttp_dozlew_wremq();
case "usttp_dozlew_skor":
   return debug_name_usttp_dozlew_skor();
case "usttp_karlew_rasst3":
   return debug_name_usttp_karlew_rasst3();
case "usttp_karlew_rasst4":
   return debug_name_usttp_karlew_rasst4();
case "usttp_barlew_skor":
   return debug_name_usttp_barlew_skor();
case "usttp_karlew_rasst5":
   return debug_name_usttp_karlew_rasst5();
case "usttp_tolschsloq2":
   return debug_name_usttp_tolschsloq2();
case "usttp_pauza1":
   return debug_name_usttp_pauza1();
case "usttp_tolschsloq1":
   return debug_name_usttp_tolschsloq1();
case "usttp_pauza2":
   return debug_name_usttp_pauza2();
case "usttp_karpraw_rasst1":
   return debug_name_usttp_karpraw_rasst1();
case "usttp_barpraw_skorrask":
   return debug_name_usttp_barpraw_skorrask();
case "usttp_barpraw_koorpusk":
   return debug_name_usttp_barpraw_koorpusk();
case "usttp_barpraw_koorstop":
   return debug_name_usttp_barpraw_koorstop();
case "usttp_barlew_skorrask":
   return debug_name_usttp_barlew_skorrask();
case "usttp_barlew_koorpusk":
   return debug_name_usttp_barlew_koorpusk();
case "usttp_barlew_koorstop":
   return debug_name_usttp_barlew_koorstop();
default: 
   return "NAN";
} 
 }
    }
 }
//______________________________________________________________________________________________++++++
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//++++++++++++++++++++++__________________________________________________________+_______________++++
//++++++++++++++++++++++++++++++++________++++________++++++++++++++++++++++++++++++++________________
//________________________++++________++++________++++________________________++++++++++++++++________
//+__+_++++++_______++_++++_++++_+++++________________________________________________________________
//____++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++______
//__________________________________++++++++++++______________________________________________________
//____________________________________________________________________________________________________
//____________________________________________________________________________________________________
