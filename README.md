# ZagreuS Builder
ZagreuS Builder 1.0.1 - Full Source Code
# Requirements
- Visual Studio
- .NET Framework 4
- - - -
<pre>

    $$$$$$\     $$$$$$$\                                          $$\                         
  $$$ ___$$$\   $$  __$$\                                         \__|                        
 $$ _/   \_$$\  $$ |  $$ |$$\   $$\ $$$$$$$\   $$$$$$$\  $$$$$$\  $$\ $$$$$$\$$$$\   $$$$$$\  
$$ / $$$$$\ $$\ $$$$$$$  |$$ |  $$ |$$  __$$\ $$  _____|$$  __$$\ $$ |$$  _$$  _$$\ $$  __$$\ 
$$ |$$  $$ |$$ |$$  __$$< $$ |  $$ |$$ |  $$ |$$ /      $$ |  \__|$$ |$$ / $$ / $$ |$$$$$$$$ |
$$ |$$ /$$ |$$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |      $$ |      $$ |$$ | $$ | $$ |$$   ____|
$$ |\$$$$$$$$  |$$ |  $$ |\$$$$$$  |$$ |  $$ |\$$$$$$$\ $$ |      $$ |$$ | $$ | $$ |\$$$$$$$\ 
\$$\ \________/ \__|  \__| \______/ \__|  \__| \_______|\__|      \__|\__| \__| \__| \_______|
 \$$$\   $$$\                                                                                 
  \_$$$$$$  _|                                                                                
    \______/                                                                                  

        Analysis by: bfalk escobark
                For: <redacted>
                     01.04.23

Target Info
{
	|- Name			  : "ZagreuS Builder.exe"
	|- Runtime		  : .NET/CIL (JIT)
	  |- Version	  : .NET Framework 4.6.1
	  |- Language	  : VB.NET
	  |- Architecture : AnyCPU (x64 preferred)
	  |- Timestamp	  : 5F8B2D19 (10/17/2020 6:42:49 PM)
	
	|- Protectors:
	  |- DNGuard
}

Notes
{
	|- Licensing System just doesn't work
	  |- it just sucks
}

License
{
	|- WindowsSettings.ini
	  |- Convert 
	  |- Data: Hex To String -> Base64 Encode -> Increment every byte by 1 of:
	  {
	  	"Port
	  	=
	  	13377
	  	<DI>
	  	HardwareID
	  	=
	  	%hwid%
	  	<DI>
	  	IsReg
	  	=
	  	%hwid%%username%
	  	<DI>"
	  }
	  
}

Cryptography
{
	|- "Private_key.txt" (File)
	  |- Type: RSA (Private Key)
	  |- Process
	  {
	    |- Base64 Encode 'new RSA().ToXml(includePrivateParameters=true)'
	  }
	  
	|- "Public_key.txt" (File)
	  |- Type: RSA (Public Key)
      |- Process
	  {
	    |- Base64 Encode 'new RSA().ToXml(includePrivateParameters=false)'
	  }
	
	|- "Xor String Shift"
	  |- Methods
	    |- "cqZcjtUFrXXKYNvNoTYltwK" (unused)
	      |- RID:   207
	      |- RVA:   0x00007F0C
	      |- Token: 0x060000CF
	    |- "gfucUokgDmMRMocusOrgsPZ"
	      |- RID:   209
	      |- RVA:   0x00007FC4
	      |- Token: 0x060000D1
	    |- "DUtKARBaGcYrjGvQbkDBLsZ"
	      |- RID:   217
	      |- RVA:   0x000083A8
	      |- Token: 0x060000D9
	    |- "HwYRJPDeUsIPwotbAMNuCpb"
	      |- RID:   215
	      |- RVA:   0x0000820C
	      |- Token: 0x060000D7
	    |- "IHZdNDsOBQTjaJgKpwtMWCD" (unused)
	      |- RID:   213
	      |- RVA:   0x000083A8
	      |- Token: 0x060000D5
	    |- "mwOskFBDRtbvawPTQDkHpVG" (unused)
	      |- RID:   211
	      |- RVA:   0x00008080
	      |- Token: 0x060000D3
	  |- Return Type: System.String
	  
	  |- Type: Xor
	  
	  |- Process
	  	|- Get Int Value of 'args[1]][0]'
	  	  |- 'args[1][0]' = First character of string 'args[1]'
	  	  |- Save value as 'xorShift'
	  	|- Get Length of 'args[0]'
	  	
	  	|- For each character in 'args[0]'
	  	  |- Xor Shift character by 'xorShift'
	  	  
	|- "EncryptString"
	  |- Methods
	    |- "ffRCWQdUOPACflUJZZPQmBjV" (unused)
	      |- RID:   163
	      |- RVA:   0x00005AF8
	      |- Token: 0x060000A3
	    |- "ffRCWQdUOPAClsUJZZPQmBjV" (unused)
	      |- RID:   171
	      |- RVA:   0x00006138
	      |- Token: 0x060000AB
	    |- "ffRCWQdUOPAClUdJZZPQmBjV" (unused)
	      |- RID:   172
	      |- RVA:   0x00006200
	      |- Token: 0x060000AC
	    |- "ffRCWQdUOPAClUJfsZZPQmBjV" (unused)
	      |- RID:   167
	      |- RVA:   0x00005E18
	      |- Token: 0x060000A7
	    |- "ffRCWQdUOPAClUJsfZZPQmBjV" (unused)
	      |- RID:   170
	      |- RVA:   0x00006070
	      |- Token: 0x060000AA
	    |- "ffRCWQdUOPAClUJsZZPQmBjV" (unused)
	      |- RID:   168
	      |- RVA:   0x00005EE0
	      |- Token: 0x060000A8
	    |- "ffRCWQdUOPAClUJZfsZPQmBjV" (unused)
	      |- RID:   169
	      |- RVA:   0x00005FA8
	      |- Token: 0x060000A9
	    |- "ffRCWQdUOPAClUJZZPQmBjV" (unused)
	      |- RID:   174
	      |- RVA:   0x00006978
	      |- Token: 0x060000AE
	    |- "ffRCWQdUOPAClUsfJZZPQmBjV" (unused)
	      |- RID:   165
	      |- RVA:   0x00005C88
	      |- Token: 0x060000A5
	    |- "ffRCWQdUOPAClUsJZZPQmBjV" (unused)
	      |- RID:   164
	      |- RVA:   0x00005BC0
	      |- Token: 0x060000A4
	    |- "ffRCWQdUOPfAClUJZZsfPQmBjV" (unused)
	      |- RID:   166
	      |- RVA:   0x00005D50
	      |- Token: 0x060000A6
	  |- Return Type: System.String
	  
	  |- Type: Rijndael (Rfc2898, CBC)
	  
	  |- Key : "ffRCWQdUOPAClUJZZPQmBjV"
	  |- IV  : { 1, 2, 3, 4, 5, 6, 7, 8 }
}

Identifiable Information
{
	|- HWID:
	  |- C Drive ID
	  |- MAC Address (WMI)
	  |- OS (WMI)
	    |- "SerialNumber"
	  |- CPU (WMI)
	    |- "processorID"
	  |- Logical Disk (WMI)
	    |- "VolumeSerialNumber"
	|- Environment
	  |- OS Version
	  |- 'Current user' Name
	  |- Machine Name
}

Ransomware
{
    |- Variables:
      |- Tracking Link : https://2no.co/1SHYt7
      |- Email		   : Lock-Ransom@protonmail.com
      |- Bitcoin Wallet: "js97xc025fwviwhdg53gla97xc025fwv"
      |- Price		   : 980 ($)
      |- File Extension: ".ZareuS"
      
    |- "HELP_DECRYPT_YOUR_FILES.txt"
    {
      Oops All Of your important files were encrypted Like document pictures videos etc..
    	  
	  Don't worry, you can return all your files!
      All your files, documents, photos, databases and other important files are encrypted by a strong encryption.
    	   
      How to recover files?
      RSA is a asymmetric cryptographic algorithm, you need one key for encryption and one key for decryption so you need private key to recover your files. It’s not possible to recover your files without private key.
      The only method of recovering files is to purchase an unique private key.Only we can give you this key and only we can recover your files.
    	   
      What guarantees you have?
      As evidence, you can send us 1 file to decrypt by email We will send you a recovery file  Prove that we can decrypt your file
    	  
      Please You must follow these steps carefully to decrypt your files:
      Send $%price% worth of bitcoin to wallet: %wallet%
      after payment,we will send you Decryptor software
      contact email: %email%
      
      Your personal ID: %id%
    }
	|- Targets:
	{
		".txt, .doc, .docx, .mp3, .xls, .xlsx, .ppt, .sql,
		.wmv, .mp4, .mp3, .dll, .jar, .pptx, .odt, .jpg,
		.tar, .gz, .bmp, .pbm, .rtf, .png, .csv, .sql,
		.mdb, .sln, .phpavi, .mov, .flv, .amv, .mpv, .mtv,
		.asp, .aspx, .html, .xml, .psd, .pdf, .exe, .rv,
		.rvx, .ved, .wm, .wmv, .TXT, .JPG, .rar, .xwmv,
		.wma, .midi, .fla, .pdf, .wma, .ico, .gif, .GIF,
		.ogg, .mpg, .icns, .RAR, .png, .zip, .BAT, .Exe,
		.c, .exe, .PNG, .7z, .exe, .EXE, .sql, .mp4,
		.7z, .rar, .m4a, .wma, .avi, .wmv, .csv, .d3dbsp,
		.zip, .sie, .sum, .ibank, .t13, .t12, .qdf, .gdb,
		.tax, .pkpass, .bc6, .bc7, .bkp, .qic, .bkf, .sidn,
		.sidd, .mddata, .itl, .itdb, .icxs, .hvpl, .hplg, .hkdb,
		.mdbackup, .syncdb, .gho, .cas, .svg, .map, .wmo, .itm,
		.sb, .fos, .mov, .vdf, .ztmp, .sis, .sid, .ncf,
		.menu, .layout, .dmp, .blob, .esm, .vcf, .vtf, .dazip,
		.fpk, .mlx, .kf, .iwd, .vpk, .tor, .psk, .rim,
		.w3x, .fsh, .ntl, .arch00, .lvl, .snx, .cfr, .ff,
		.vpp_pc, .lrf, .m2, .mcmeta, .vfs0, .mpqge, .kdb, .db0,
		.dba, .rofl, .hkx, .bar, .upk, .das, .iwi, .litemod,
		.asset, .forge, .ltx, .bsa, .apk, .re4, .sav, .lbf,
		.slm, .bik, .epk, .rgss3a, .pak, .bigwallet, .wotreplay, .xxx,
		.desc, .py, .m3u, .flv, .js, .css, .rb, .png,
		.jpeg, .txt, .p7c, .p7b, .p12, .pfx, .pem, .crt,
		.cer, .der, .x3f, .srw, .pef, .ptx, .r3d, .rw2,
		.rwl, .raw, .raf, .orf, .nrw, .mrwref, .mef, .erf,
		.kdc, .dcr, .cr2, .crw, .cerber, .WNCRY, .dsewrbg, .bay,
		.sr2, .srf, .arw, .3fr, .dng, .jpe, .jpg, .cdr,
		.indd, .ai, .eps, .pdf, .pdd, .psd, .dbf, .mdf,
		.wb2, .rtf, .wpd, .dxg, .xf, .dwg, .pst, .vbs,
		.accdb, .mdb, .pptm, .pptx, .ppt, .xlk, .xlsb, .xlsm,
		.xlsx, .xls, .wps, .docm, .docx, .doc, .odb, .odc,
		.odm, .odp, .ods, .odt"
	}
	
	|- Encryption
	  |- "EncryptFile"
	    |- RID:   36
	    |- RVA:   0x00002B30
	    |- Token: 0x06000024
	    
	    |- Type: Rijndael (Rfc2898, CBC)
	    
	    |- Size:
	      |- Key:   32
	      |- Block: 16
	    
	    |- Key: Random Non-Zero bytes (RNGCrypto)
	      |- Length: 30
	      
	    |- IV:
	    { 0x6F, 0x36, 0x38, 0x30, 0x36, 0x36, 0x34,
	      0x32, 0x6B, 0x62, 0x4D, 0x37, 0x63, 0x35 }
	      
	|- Process
	{
		|- Disable UAC (via registry, 'HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\EnableLUA' set to 0)
		|- Deletes all shadow copies of every volumes (vssadmin.exe)
		
		|- Check if encrypt
		  |- Desktop
		  |- My Videos
		  |- My Pictures
		  |- My Music
		  |- Links
		  |- Favorites
		  |- Downloads
		  |- OneDrive
		  |- Documents
		  |- Contacts
		  |- Saved Games
		  |- Searches
		  |- All Logical Drives
		    |- Encrypt every file & sub-directories
		      |- Password: SHA256 Hash of file
		      
		|- Open Tracking Link
		  |- Default: https://2no.co/1SHYt7
	}
}
</pre>
