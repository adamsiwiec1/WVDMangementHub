######################### Login TO RDS ####################################
function login-rds{
    $rdsAccount = Add-RdsAccount -DeploymentUrl "https://rdbroker.wvd.microsoft.com"
    return $rdsAccount
}
######################### Choose Tenant ####################################
function tenant-pool-menu {
    Write-Host "================ Enter Tenant & Host Pool Information ================"
    $rdsTenant = Read-Host "Please enter the RDS Tenant you wish to access: "
    $rdsHostPool = Read-Host "Please enter the RDS Host Pool you wish to access: "
    return $rdsTenant, $rdsHostPool
}
######################### Menu ####################################
function rds-menu {
    Clear-Host
    Write-Host "================ RDS Menu ================"
    Write-Host "Welcome $rdsUser, make a selection below for what you want to do: "
    Write-Host "1: Press '1' to list all logged in users."
    Write-Host "2: Press '2' to add a user to an app group."
    Write-Host "3: Press '3' to list all app groups."
    Write-Host "4: Press '4' to force a user logoff."
    Write-Host "Q: Press 'Q' to quit."
}
######################### Prompt User ####################################
function prompt-user {
    do
    {
    rds-menu
    $selection = Read-Host "Please make a selection"
    switch ($selection)
    {
    '1' {
    'get logged in users'
    Get-RdsUserSession -TenantName $rdsTenant -HostPoolName $rdsHostPool
    }
    '2' {
    'add a user to an app group'
    $appGroupName = Read-Host "App Group Name: "
    $upn = Read-Host "UPN for user ex. bsmith@nrtbus.com: "
    Add-RdsAppGroupUser -TenantName $rdsTenant -HostPoolName $rdsHostPool -AppGroupName $appGroupName -UserPrincipalName $upn
    }
    '3' {
    'show all app groups'
    Get-RdsAppGroup -TenantName $rdsTenant -HostPoolName $rdsHostPool
    }
    '4' {
    'logoff a user'
    $upn = Read-Host "UPN for user to logoff ex. bsmith@nrtbus.com: "
    Get-RdsUserSession -TenantName $rdsTenant -HostPoolName $rdsHostPool | where { $_.UserPrincipalName -eq $upn } | Invoke-RdsUserSessionLogoff -NoUserPrompt
    }
    }
    pause
    }
    until ($selection -eq 'q')
}


######################### Prompt User ####################################
function Main {
#login-rds
$rdsTenant, $rdsHostPool = tenant-pool-menu
Get-RdsUserSession -TenantName $rdsTenant -HostPoolName $rdsHostPool
prompt-user
}
Main

