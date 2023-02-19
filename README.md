
![POC](https://user-images.githubusercontent.com/57565283/219952631-6ea87ac2-06a4-4373-8ba4-f20328377d73.gif)

# Bypass-PS-Restrictions
This repo is about bypassing Powershell restrictions such as GPO, AV and EDR.

# Testing Environment
The file was tested on restrictions environments Windows endpoint and server with GPO restrictions, AV and EDR.

# Compiling the file:
In CMD copy and paste the following command:

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /reference:"C:\Windows\assembly\GAC_MSIL\System.Management.Automation\1.0.0.0__31bf3856ad364e35\System.Management.Automation.dll" /out:POC.exe "powershellBypass.cs"

# POC

<img width="509" alt="POC1" src="https://user-images.githubusercontent.com/57565283/219952883-35634cc5-bad0-4cfb-a649-c5ea52a30c16.PNG">
<img width="751" alt="POC2" src="https://user-images.githubusercontent.com/57565283/219952890-321ee571-bd67-464b-b78e-f4be92a0bb5f.PNG">

