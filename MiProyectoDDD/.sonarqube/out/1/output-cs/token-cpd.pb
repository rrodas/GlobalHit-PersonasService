¾
I/Users/user/Documents/MiProyecto/domain/domain.services/CountryService.cs
	namespace 	
domain
 
. 
domain 
. 
services  
.  !
country! (
{ 
public 

class 
CuntryDomainService $
:% &!
ICountryDomainService' <
{ 
public 
string 
Hello 
( 
) 
{ 	
return		 
$str		 
;		  
}

 	
} 
} »
J/Users/user/Documents/MiProyecto/domain/domain.services/ICountryService.cs
	namespace 	
domain
 
. 
domain 
. 
services  
.  !
country! (
{ 
public 	
	interface
 !
ICountryDomainService )
{ 
string	 
Hello 
( 
) 
; 
} 
}		 Þ
T/Users/user/Documents/MiProyecto/domain/repositories.contracts/ICountryRepository.cs
	namespace 	
domain
 
. 
repositories 
. 
	contracts '
.' (
country( /
{ 
public 

	interface 
ICountryRepository '
{ 
void		 
Create		 
(		 
City		 

carEntitie		 #
)		# $
;		$ %
void

 
Update

 
(

 
City

 

carEntitie

 #
)

# $
;

$ %
void 
Delete 
( 
int 
id 
) 
; 
City 
GetCity 
( 
int 
id 
) 
; 
List 
< 
City 
> 
	GetCities 
( 
) 
; 
} 
} 