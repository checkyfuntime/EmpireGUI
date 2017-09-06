using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    public class Modules
    {
        public class Agent
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DaemonLocation
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DaemonName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Listener
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SafeChecks
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UserAgent
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Forest
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CheckShareAccess
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ComputerFilter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ComputerName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Delay
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Domain
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DomainController
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NoPing
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Threads
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Language
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OutFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Command
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CredID
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Instance
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Password
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Proxy
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProxyCreds
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UserName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Debug
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HistoryCount
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WatchGroups
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WatchProcesses
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WatchUsers
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Desktop
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Image
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Login
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExcludeOwned
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExcludeProgramFiles
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExcludeWindows
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExhaustUDP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HTTPPort
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Hostname
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class IP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NBNS
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NBNSLimit
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RunTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferIP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TaskDelete
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Taskname
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Trigger
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WPADDirectHosts
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WPADPort
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Cleanup
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NoLock
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CheckWriteAccess
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CreationTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExcludeHidden
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FreshEXES
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LastAccessTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OfficeDocs
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchSYSVOL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ShareList
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Terms
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GroupName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ADSpath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FullData
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GUID
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SiteName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Domain2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Endin
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Groups
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Id
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Krbtgt
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Sid
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Sids
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class User
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Dc
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Path
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Ratio
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AppName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ListApps
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class KeyChain
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TempDir
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProcId
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProcName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProcessName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Silent
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Sleep
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PID
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Shellcode
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExtFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LNKPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RegPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LocalGroup
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class BindDN
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LDAPAddress
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class __invalid_type__4624
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class __invalid_type__4648
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AppLocker
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PSScripts
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SavedRDP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ServiceName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Search
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Type
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LDAP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ADSprefix
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DistinguishedName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Filter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Name
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ResolveGUIDs
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RightsFilter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SamAccountName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Ntlm
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CIDR
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Range
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CheckMgmt
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DomainServiceAccount
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UDPTimeOut
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Username2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ClearValue
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PropertyName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PropertyValue
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PropertyXorValue
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SID2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CheckInterval
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TargetDomain
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ResultFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RemotePassword
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RemoteUserName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Port
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Target
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class URL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LockoutThreshold
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PasswordList
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ShowVerbose
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class StopOnSuccess
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UserList
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LocalImagePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Accessed
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class All
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Created
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FilePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Modified
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OldFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Query
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TargetServer
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UserFilter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AllUsers
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class IconType
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Message
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Title
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LoadedProcesses
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ADSPath2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class EventLogID
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class KeyName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DumpFilePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProcessId
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Number
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExitCount
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Verbose
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Dictionary
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Directory
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Rhosts
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UseSSL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Hash
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Keytab
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Principal
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Delay2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Ip2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Portrange
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Protocol
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Groups2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class User2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LoginHookScript
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Rc4
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Service
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Target2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Group
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class BackupPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Groupname2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FolderName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Index
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LocalDestination
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RemoteDestination
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DriveLetter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CleanUp2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ID2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class VoiceText
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Method
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CheckAccess
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ShowAll
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Stealth
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Rhost
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Description
        {
            //public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LastSuccess
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Owner
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OwnerName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Schedule
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Protocol2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RequMethod
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ConsoleOutput
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ConsoleStatus
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ConsoleUnique
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ElevatedPrivilege
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HTTP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HTTPAuth
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HTTPContentType
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HTTPResponse
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Inspect
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LLMNR
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NBNSTypes
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProxyPort
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RunCount
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SMB
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferHostsIgnore
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferHostsReply
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferIPsIgnore
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferIPsReply
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferLearning
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferLearningDelay
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SpooferRepeat
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WPADAuth
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MDNS
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MDNSTypes
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CheckAll
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class VideoURL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PipeName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RevToSelf
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Technique
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WhoAmI
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AuthPackage
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DomainName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExistingWinLogon
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LogonType
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NewWinLogon
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ScriptCmd
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ScriptPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Folder
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ZipFileName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Arguments
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Cmd
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ShowWindow
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ConType
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class IpAddress
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DefaultFolder
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Delete
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Repair
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AtStartup
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DailyTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SubName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CSVFolder
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CSVPrefix
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CollectionMethod
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GlobalCatalog
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchForest
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Password2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ResolveSids
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Source
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Binary
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TargetBinary
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FileName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Hour
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Hourly
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Remove
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class File
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Keywords
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MaxResults
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MaxSearch
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MaxThreads
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WriteablePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Proxy2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SMB1
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Service2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Usernames
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Text
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Voice
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OutPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RecordTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MaxEmails
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Ip3
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PrivSetting
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ServeCount
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AdminPassword
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AdminUser
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Reset
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Version
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Data
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GHFileName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GHFilePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GHPAT
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GHRepo
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GHUser
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LocalFilePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Recurse
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MonitorTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MsgText
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AllData
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Datalimit
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LogLocation
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProcessID2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchStrings
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MasterKey
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AdminCount
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AllowDelegation
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SPN
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NoDefaults
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TriggerBinary
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LogFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchTerm
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CreateProcess
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ImpersonateUser
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NoUI
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Process
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProcessArgs
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ThreadId
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Dll
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Active
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Computers
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Messages
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CollectionLimit
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PollInterval
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Depth
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OUName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Admin
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Domainadmin
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Elevate
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class List
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Revert
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Timeout
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OperatingSystem
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Ping
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Action
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExportPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TriggerName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchField
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PlistPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProgramPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class InMemory
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class IpFilter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MaxPackets
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MaxSize
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PortFilter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SavePath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class API
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ListGroups
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class MountPoint
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ShareName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class RuleName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CaptureInterface
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LibcDylib
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PcapDylib
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AllformatsOut
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExcludeHosts
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GrepOut
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HostFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Hosts
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Open
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PingOnly
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Ports
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ReadableOut
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SkipDiscovery
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TopPorts
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class XmlOut
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DllPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ExeArgs
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ForceASLR
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PEUrl
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CPUs
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Disk
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Instances
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Mem
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Printers
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Unconstrained
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DisplayName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GPOname
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Arch
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LegitimateDylibPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class VulnerableRPATH
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UseMatchingRule
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class HOST
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class NoSSL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class PORT2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class GPODisplayName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TaskAuthor
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TaskDescription
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TaskName2
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Browser
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DataType
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AllDomain
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Thorough
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class IL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class O
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class P
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class U
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class IdleTime
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class VNCpass
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Attachment
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Body
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Subject
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TargetList
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Targets
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Template
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FoundOnly
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Identity
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class LDAPFilter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OutputFormat
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchBase
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SearchScope
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Server
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Lhost
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Lport
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Payload
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SSL
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class JMXConsole
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WarFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Dept
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Email
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class FullName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class JobTitle
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SysWow64
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OnLogon
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Persistent
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class StopTrace
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class TraceFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Options
        {
            public Agent Agent { get; set; }
            public DaemonLocation DaemonLocation { get; set; }
            public DaemonName DaemonName { get; set; }
            public Listener Listener { get; set; }
            public SafeChecks SafeChecks { get; set; }
            public UserAgent UserAgent { get; set; }
            public Forest Forest { get; set; }
            public CheckShareAccess CheckShareAccess { get; set; }
            public ComputerFilter ComputerFilter { get; set; }
            public ComputerName ComputerName { get; set; }
            public Delay Delay { get; set; }
            public Domain Domain { get; set; }
            public DomainController DomainController { get; set; }
            public NoPing NoPing { get; set; }
            public Threads Threads { get; set; }
            public Language Language { get; set; }
            public OutFile OutFile { get; set; }
            public Command Command { get; set; }
            public CredID CredID { get; set; }
            public Instance Instance { get; set; }
            public Password Password { get; set; }
            public Proxy Proxy { get; set; }
            public ProxyCreds ProxyCreds { get; set; }
            public UserName UserName { get; set; }
            public Debug Debug { get; set; }
            public HistoryCount HistoryCount { get; set; }
            public WatchGroups WatchGroups { get; set; }
            public WatchProcesses WatchProcesses { get; set; }
            public WatchUsers WatchUsers { get; set; }
            public Desktop Desktop { get; set; }
            public Image Image { get; set; }
            public Login Login { get; set; }
            public ExcludeOwned ExcludeOwned { get; set; }
            public ExcludeProgramFiles ExcludeProgramFiles { get; set; }
            public ExcludeWindows ExcludeWindows { get; set; }
            public ExhaustUDP ExhaustUDP { get; set; }
            public HTTPPort HTTPPort { get; set; }
            public Hostname Hostname { get; set; }
            public IP IP { get; set; }
            public NBNS NBNS { get; set; }
            public NBNSLimit NBNSLimit { get; set; }
            public RunTime RunTime { get; set; }
            public SpooferIP SpooferIP { get; set; }
            public TaskDelete TaskDelete { get; set; }
            public Taskname Taskname { get; set; }
            public Trigger Trigger { get; set; }
            public WPADDirectHosts WPADDirectHosts { get; set; }
            public WPADPort WPADPort { get; set; }
            public Cleanup Cleanup { get; set; }
            public NoLock NoLock { get; set; }
            public CheckWriteAccess CheckWriteAccess { get; set; }
            public CreationTime CreationTime { get; set; }
            public ExcludeHidden ExcludeHidden { get; set; }
            public FreshEXES FreshEXES { get; set; }
            public LastAccessTime LastAccessTime { get; set; }
            public OfficeDocs OfficeDocs { get; set; }
            public SearchSYSVOL SearchSYSVOL { get; set; }
            public ShareList ShareList { get; set; }
            public Terms Terms { get; set; }
            public GroupName GroupName { get; set; }
            public ADSpath ADSpath { get; set; }
            public FullData FullData { get; set; }
            public GUID GUID { get; set; }
            public SiteName SiteName { get; set; }
            public Domain2 domain { get; set; }
            public Endin endin { get; set; }
            public Groups groups { get; set; }
            public Id id { get; set; }
            public Krbtgt krbtgt { get; set; }
            public Sid sid { get; set; }
            public Sids sids { get; set; }
            public User user { get; set; }
            public Dc dc { get; set; }
            public Path Path { get; set; }
            public Ratio Ratio { get; set; }
            public AppName AppName { get; set; }
            public ListApps ListApps { get; set; }
            public KeyChain KeyChain { get; set; }
            public TempDir TempDir { get; set; }
            public ProcId ProcId { get; set; }
            public ProcName ProcName { get; set; }
            public ProcessName ProcessName { get; set; }
            public Silent Silent { get; set; }
            public Sleep Sleep { get; set; }
            public PID PID { get; set; }
            public Shellcode Shellcode { get; set; }
            public ExtFile ExtFile { get; set; }
            public LNKPath LNKPath { get; set; }
            public RegPath RegPath { get; set; }
            public LocalGroup LocalGroup { get; set; }
            public BindDN BindDN { get; set; }
            public LDAPAddress LDAPAddress { get; set; }
            public __invalid_type__4624 __invalid_name__4624 { get; set; }
            public __invalid_type__4648 __invalid_name__4648 { get; set; }
            public AppLocker AppLocker { get; set; }
            public PSScripts PSScripts { get; set; }
            public SavedRDP SavedRDP { get; set; }
            public ServiceName ServiceName { get; set; }
            public Search Search { get; set; }
            public Type Type { get; set; }
            public LDAP LDAP { get; set; }
            public ADSprefix ADSprefix { get; set; }
            public DistinguishedName DistinguishedName { get; set; }
            public Filter Filter { get; set; }
            public Name Name { get; set; }
            public ResolveGUIDs ResolveGUIDs { get; set; }
            public RightsFilter RightsFilter { get; set; }
            public SamAccountName SamAccountName { get; set; }
            public Ntlm ntlm { get; set; }
            public CIDR CIDR { get; set; }
            public Range Range { get; set; }
            public CheckMgmt CheckMgmt { get; set; }
            public DomainServiceAccount DomainServiceAccount { get; set; }
            public UDPTimeOut UDPTimeOut { get; set; }
            public Username2 Username { get; set; }
            public ClearValue ClearValue { get; set; }
            public PropertyName PropertyName { get; set; }
            public PropertyValue PropertyValue { get; set; }
            public PropertyXorValue PropertyXorValue { get; set; }
            public SID2 SID { get; set; }
            public CheckInterval CheckInterval { get; set; }
            public TargetDomain TargetDomain { get; set; }
            public ResultFile ResultFile { get; set; }
            public RemotePassword RemotePassword { get; set; }
            public RemoteUserName RemoteUserName { get; set; }
            public Port Port { get; set; }
            public Target Target { get; set; }
            public URL URL { get; set; }
            public LockoutThreshold LockoutThreshold { get; set; }
            public PasswordList PasswordList { get; set; }
            public ShowVerbose ShowVerbose { get; set; }
            public StopOnSuccess StopOnSuccess { get; set; }
            public UserList UserList { get; set; }
            public LocalImagePath LocalImagePath { get; set; }
            public Accessed Accessed { get; set; }
            public All All { get; set; }
            public Created Created { get; set; }
            public FilePath FilePath { get; set; }
            public Modified Modified { get; set; }
            public OldFile OldFile { get; set; }
            public Query Query { get; set; }
            public TargetServer TargetServer { get; set; }
            public UserFilter UserFilter { get; set; }
            public AllUsers AllUsers { get; set; }
            public IconType IconType { get; set; }
            public Message Message { get; set; }
            public Title Title { get; set; }
            public LoadedProcesses LoadedProcesses { get; set; }
            public ADSPath2 ADSPath { get; set; }
            public EventLogID EventLogID { get; set; }
            public KeyName KeyName { get; set; }
            public DumpFilePath DumpFilePath { get; set; }
            public ProcessId ProcessId { get; set; }
            public Number Number { get; set; }
            public ExitCount ExitCount { get; set; }
            public Verbose Verbose { get; set; }
            public Dictionary Dictionary { get; set; }
            public Directory Directory { get; set; }
            public Rhosts Rhosts { get; set; }
            public UseSSL UseSSL { get; set; }
            public Hash Hash { get; set; }
            public Keytab Keytab { get; set; }
            public Principal Principal { get; set; }
            public Delay2 delay { get; set; }
            public Ip2 ip { get; set; }
            public Portrange portrange { get; set; }
            public Protocol protocol { get; set; }
            public Groups2 Groups { get; set; }
            public User2 User { get; set; }
            public LoginHookScript LoginHookScript { get; set; }
            public Rc4 rc4 { get; set; }
            public Service service { get; set; }
            public Target2 target { get; set; }
            public Group Group { get; set; }
            public BackupPath BackupPath { get; set; }
            public Groupname2 groupname { get; set; }
            public FolderName FolderName { get; set; }
            public Index Index { get; set; }
            public LocalDestination LocalDestination { get; set; }
            public RemoteDestination RemoteDestination { get; set; }
            public DriveLetter DriveLetter { get; set; }
            public CleanUp2 CleanUp { get; set; }
            public ID2 ID { get; set; }
            public VoiceText VoiceText { get; set; }
            public Method Method { get; set; }
            public CheckAccess CheckAccess { get; set; }
            public ShowAll ShowAll { get; set; }
            public Stealth Stealth { get; set; }
            public Rhost Rhost { get; set; }
            public Description Description { get; set; }
            public LastSuccess LastSuccess { get; set; }
            public Owner Owner { get; set; }
            public OwnerName OwnerName { get; set; }
            public Schedule Schedule { get; set; }
            public Protocol2 Protocol { get; set; }
            public RequMethod RequMethod { get; set; }
            public ConsoleOutput ConsoleOutput { get; set; }
            public ConsoleStatus ConsoleStatus { get; set; }
            public ConsoleUnique ConsoleUnique { get; set; }
            public ElevatedPrivilege ElevatedPrivilege { get; set; }
            public HTTP HTTP { get; set; }
            public HTTPAuth HTTPAuth { get; set; }
            public HTTPContentType HTTPContentType { get; set; }
            public HTTPResponse HTTPResponse { get; set; }
            public Inspect Inspect { get; set; }
            public LLMNR LLMNR { get; set; }
            public NBNSTypes NBNSTypes { get; set; }
            public ProxyPort ProxyPort { get; set; }
            public RunCount RunCount { get; set; }
            public SMB SMB { get; set; }
            public SpooferHostsIgnore SpooferHostsIgnore { get; set; }
            public SpooferHostsReply SpooferHostsReply { get; set; }
            public SpooferIPsIgnore SpooferIPsIgnore { get; set; }
            public SpooferIPsReply SpooferIPsReply { get; set; }
            public SpooferLearning SpooferLearning { get; set; }
            public SpooferLearningDelay SpooferLearningDelay { get; set; }
            public SpooferRepeat SpooferRepeat { get; set; }
            public WPADAuth WPADAuth { get; set; }
            public MDNS mDNS { get; set; }
            public MDNSTypes mDNSTypes { get; set; }
            public CheckAll CheckAll { get; set; }
            public VideoURL VideoURL { get; set; }
            public PipeName PipeName { get; set; }
            public RevToSelf RevToSelf { get; set; }
            public Technique Technique { get; set; }
            public WhoAmI WhoAmI { get; set; }
            public AuthPackage AuthPackage { get; set; }
            public DomainName DomainName { get; set; }
            public ExistingWinLogon ExistingWinLogon { get; set; }
            public LogonType LogonType { get; set; }
            public NewWinLogon NewWinLogon { get; set; }
            public ScriptCmd ScriptCmd { get; set; }
            public ScriptPath ScriptPath { get; set; }
            public Folder Folder { get; set; }
            public ZipFileName ZipFileName { get; set; }
            public Arguments Arguments { get; set; }
            public Cmd Cmd { get; set; }
            public ShowWindow ShowWindow { get; set; }
            public ConType ConType { get; set; }
            public IpAddress IpAddress { get; set; }
            public DefaultFolder DefaultFolder { get; set; }
            public Delete Delete { get; set; }
            public Repair Repair { get; set; }
            public AtStartup AtStartup { get; set; }
            public DailyTime DailyTime { get; set; }
            public SubName SubName { get; set; }
            public CSVFolder CSVFolder { get; set; }
            public CSVPrefix CSVPrefix { get; set; }
            public CollectionMethod CollectionMethod { get; set; }
            public GlobalCatalog GlobalCatalog { get; set; }
            public SearchForest SearchForest { get; set; }
            public Password2 password { get; set; }
            public ResolveSids ResolveSids { get; set; }
            public Source Source { get; set; }
            public Binary Binary { get; set; }
            public TargetBinary TargetBinary { get; set; }
            public FileName FileName { get; set; }
            public Hour Hour { get; set; }
            public Hourly Hourly { get; set; }
            public Remove Remove { get; set; }
            public File File { get; set; }
            public Keywords Keywords { get; set; }
            public MaxResults MaxResults { get; set; }
            public MaxSearch MaxSearch { get; set; }
            public MaxThreads MaxThreads { get; set; }
            public WriteablePath WriteablePath { get; set; }
            public Proxy2 Proxy_ { get; set; }
            public SMB1 SMB1 { get; set; }
            public Service2 Service { get; set; }
            public Usernames Usernames { get; set; }
            public Text Text { get; set; }
            public Voice Voice { get; set; }
            public OutPath OutPath { get; set; }
            public RecordTime RecordTime { get; set; }
            public MaxEmails MaxEmails { get; set; }
            public Ip3 Ip { get; set; }
            public PrivSetting PrivSetting { get; set; }
            public ServeCount ServeCount { get; set; }
            public AdminPassword AdminPassword { get; set; }
            public AdminUser AdminUser { get; set; }
            public Reset Reset { get; set; }
            public Version Version { get; set; }
            public Data Data { get; set; }
            public GHFileName GHFileName { get; set; }
            public GHFilePath GHFilePath { get; set; }
            public GHPAT GHPAT { get; set; }
            public GHRepo GHRepo { get; set; }
            public GHUser GHUser { get; set; }
            public LocalFilePath LocalFilePath { get; set; }
            public Recurse Recurse { get; set; }
            public MonitorTime MonitorTime { get; set; }
            public MsgText MsgText { get; set; }
            public AllData AllData { get; set; }
            public Datalimit Datalimit { get; set; }
            public LogLocation LogLocation { get; set; }
            public ProcessID2 ProcessID { get; set; }
            public SearchStrings SearchStrings { get; set; }
            public MasterKey MasterKey { get; set; }
            public AdminCount AdminCount { get; set; }
            public AllowDelegation AllowDelegation { get; set; }
            public SPN SPN { get; set; }
            public NoDefaults NoDefaults { get; set; }
            public TriggerBinary TriggerBinary { get; set; }
            public LogFile LogFile { get; set; }
            public SearchTerm SearchTerm { get; set; }
            public CreateProcess CreateProcess { get; set; }
            public ImpersonateUser ImpersonateUser { get; set; }
            public NoUI NoUI { get; set; }
            public Process Process { get; set; }
            public ProcessArgs ProcessArgs { get; set; }
            public ThreadId ThreadId { get; set; }
            public Dll Dll { get; set; }
            public Active Active { get; set; }
            public Computers Computers { get; set; }
            public Messages Messages { get; set; }
            public CollectionLimit CollectionLimit { get; set; }
            public PollInterval PollInterval { get; set; }
            public Depth Depth { get; set; }
            public OUName OUName { get; set; }
            public Admin admin { get; set; }
            public Domainadmin domainadmin { get; set; }
            public Elevate elevate { get; set; }
            public List list { get; set; }
            public Revert revert { get; set; }
            public Timeout Timeout { get; set; }
            public OperatingSystem OperatingSystem { get; set; }
            public Ping Ping { get; set; }
            public Action Action { get; set; }
            public ExportPath ExportPath { get; set; }
            public TriggerName TriggerName { get; set; }
            public SearchField SearchField { get; set; }
            public PlistPath PlistPath { get; set; }
            public ProgramPath ProgramPath { get; set; }
            public InMemory InMemory { get; set; }
            public IpFilter IpFilter { get; set; }
            public MaxPackets MaxPackets { get; set; }
            public MaxSize MaxSize { get; set; }
            public PortFilter PortFilter { get; set; }
            public SavePath SavePath { get; set; }
            public API API { get; set; }
            public ListGroups ListGroups { get; set; }
            public MountPoint MountPoint { get; set; }
            public ShareName ShareName { get; set; }
            public RuleName RuleName { get; set; }
            public CaptureInterface CaptureInterface { get; set; }
            public LibcDylib LibcDylib { get; set; }
            public PcapDylib PcapDylib { get; set; }
            public AllformatsOut AllformatsOut { get; set; }
            public ExcludeHosts ExcludeHosts { get; set; }
            public GrepOut GrepOut { get; set; }
            public HostFile HostFile { get; set; }
            public Hosts Hosts { get; set; }
            public Open Open { get; set; }
            public PingOnly PingOnly { get; set; }
            public Ports Ports { get; set; }
            public ReadableOut ReadableOut { get; set; }
            public SkipDiscovery SkipDiscovery { get; set; }
            public TopPorts TopPorts { get; set; }
            public XmlOut XmlOut { get; set; }
            public DllPath DllPath { get; set; }
            public ExeArgs ExeArgs { get; set; }
            public ForceASLR ForceASLR { get; set; }
            public PEUrl PEUrl { get; set; }
            public CPUs CPUs { get; set; }
            public Disk Disk { get; set; }
            public Instances Instances { get; set; }
            public Mem Mem { get; set; }
            public Printers Printers { get; set; }
            public Unconstrained Unconstrained { get; set; }
            public DisplayName DisplayName { get; set; }
            public GPOname GPOname { get; set; }
            public Arch Arch { get; set; }
            public LegitimateDylibPath LegitimateDylibPath { get; set; }
            public VulnerableRPATH VulnerableRPATH { get; set; }
            public UseMatchingRule UseMatchingRule { get; set; }
            public HOST HOST { get; set; }
            public NoSSL NoSSL { get; set; }
            public PORT2 PORT { get; set; }
            public GPODisplayName GPODisplayName { get; set; }
            public TaskAuthor TaskAuthor { get; set; }
            public TaskDescription TaskDescription { get; set; }
            public TaskName2 TaskName { get; set; }
            public Browser Browser { get; set; }
            public DataType DataType { get; set; }
            public AllDomain AllDomain { get; set; }
            public Thorough Thorough { get; set; }
            public IL iL { get; set; }
            public O o { get; set; }
            public P p { get; set; }
            public U u { get; set; }
            public IdleTime IdleTime { get; set; }
            public VNCpass VNCpass { get; set; }
            public Attachment Attachment { get; set; }
            public Body Body { get; set; }
            public Subject Subject { get; set; }
            public TargetList TargetList { get; set; }
            public Targets Targets { get; set; }
            public Template Template { get; set; }
            public FoundOnly FoundOnly { get; set; }
            public Identity Identity { get; set; }
            public LDAPFilter LDAPFilter { get; set; }
            public OutputFormat OutputFormat { get; set; }
            public SearchBase SearchBase { get; set; }
            public SearchScope SearchScope { get; set; }
            public Server Server { get; set; }
            public Lhost Lhost { get; set; }
            public Lport Lport { get; set; }
            public Payload Payload { get; set; }
            public SSL SSL { get; set; }
            public JMXConsole JMXConsole { get; set; }
            public WarFile WarFile { get; set; }
            public Dept Dept { get; set; }
            public Email Email { get; set; }
            public FullName FullName { get; set; }
            public JobTitle JobTitle { get; set; }
            public SysWow64 SysWow64 { get; set; }
            public OnLogon OnLogon { get; set; }
            public Persistent Persistent { get; set; }
            public StopTrace StopTrace { get; set; }
            public TraceFile TraceFile { get; set; }
        }

        public class Module
        {
            public List<string> Author { get; set; }
            public bool Background { get; set; }
            public List<object> Comments { get; set; }
            public string Description { get; set; }
            public string Language { get; set; }
            public string MinLanguageVersion { get; set; }
            public string Name { get; set; }
            public bool NeedsAdmin { get; set; }
            public bool OpsecSafe { get; set; }
            public string OutputExtension { get; set; }
            public Options options { get; set; }
            public string MinPSVersion { get; set; }
            public bool? SaveOutput { get; set; }
            public bool? RunOnDisk { get; set; }
            public List<string> Imports { get; set; }
        }

        public class RootObject
        {
            public List<Module> modules { get; set; }
        }
    }
}
