±
S/Users/user/Documents/MiProyecto/application/application.services/CountryService.cs
	namespace 	
application
 
. 
application !
.! "
services" *
.* +
country+ 2
{ 
public		 

class		 
CountryService		 
:		  !
ICountryService		" 1
{

 
readonly 
DomainService 
. !
ICountryDomainService 4
_domainIService5 D
;D E
readonly 
DomainCotract 
. 
ICountryRepository 1
_domainICotract2 A
;A B
public 
CountryService 
( 
DomainService +
.+ ,!
ICountryDomainService, A!
domainICountryServiceB W
,W X
DomainCotractY f
.f g
ICountryRepositoryg y
domainICotract	z ˆ
)
ˆ ‰
{ 	
this 
. 
_domainIService  
=! "!
domainICountryService# 8
;8 9
this 
. 
_domainICotract  
=! "
domainICotract# 1
;1 2
} 	
public 
void 
Create 
( 
City 
cityEntitie  +
)+ ,
{ 	
_domainICotract 
. 
Create "
(" #
cityEntitie# .
). /
;/ 0
} 	
public 
void 
Delete 
( 
int 
id !
)! "
{ 	
_domainICotract 
. 
Delete "
(" #
id# %
)% &
;& '
} 	
public 
List 
< 
City 
> 
	GetCities #
(# $
)$ %
{ 	
return 
_domainICotract "
." #
	GetCities# ,
(, -
)- .
;. /
}   	
public"" 
City"" 
GetCity"" 
("" 
int"" 
id""  "
)""" #
{## 	
return$$ 
_domainICotract$$ "
.$$" #
GetCity$$# *
($$* +
id$$+ -
)$$- .
;$$. /
}%% 	
public'' 
string'' 
Hello'' 
('' 
)'' 
{(( 	
return)) 
_domainIService)) "
.))" #
Hello))# (
())( )
)))) *
;))* +
}** 	
public,, 
void,, 
Update,, 
(,, 
City,, 
cityEntitie,,  +
),,+ ,
{-- 	
_domainICotract.. 
... 
Update.. "
(.." #
cityEntitie..# .
)... /
;../ 0
}// 	
}00 
}11 ´
T/Users/user/Documents/MiProyecto/application/application.services/ICountryService.cs
	namespace 	
application
 
. 
application !
.! "
services" *
.* +
country+ 2
{ 
public 

	interface 
ICountryService $
{ 
string		 
Hello		 
(		 
)		 
;		 
void

 
Create

 
(

 
City

 
cityEntitie

 $
)

$ %
;

% &
void 
Update 
( 
City 
cityEntitie $
)$ %
;% &
void 
Delete 
( 
int 
id 
) 
; 
City 
GetCity 
( 
int 
id 
) 
; 
List 
< 
City 
> 
	GetCities 
( 
) 
; 
} 
} 