# Pilatus_snap
These C# codes take image with Pilatus detector. The programs have simple GUI created in Windows Forms app and UI XAML. 

These C# codes take images with Pilatus detector. They also set energy threshold of Pilatus detector. The C# codes have GUI in Windows Forms application and UI XAML. One C# code works as console application. 



The energy thershold of Pilatus detector is set by sending command setthreshold midg 5000 into the Pilatus detector. The setthreshold command sets energy threshold. The midg means mid gain amplification. It can be also lowg (low gain) or highg (high gain). The value 5000 means 5000 eV. In our experiment we used CuKalpha radiation with energy of X-rays 8040 eV or 8.04 keV. The energy threshold of Pilatus detector is usually set to the half of the full intensity of X-ray photons, which means it should be 4020 eV. The value of 5000 eV is close value to the 4020 eV. 
