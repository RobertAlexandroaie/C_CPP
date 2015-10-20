#include <iostream>
#include <fstream>
#include <string>
#include <string.h>

#include "lista.h"
#include "contact.h"

using namespace std;

Nodc::Nodc()	
{
	informatie=new Contact;
	urmator=NULL;
	precedent=NULL;
}

char Nodc::getTip()
{
	return tip;
}

void Nodc::setTip(char t)
{
	tip=t;
}

Listac::Listac()
{
	p=1;
	primul=ultimul=NULL;
	modificare=false;
}

Listac::Listac(char *s)
{
	Incarca(s);
}

Listac::Listac(const Contact &prop)
{
	ownerContact.setNume(prop.getNume());
	ownerContact.setPrenume(prop.getPrenume());
	ownerContact.setNrTel(prop.getNrTel());
}

Listac::~Listac()	
{
	Nodc *p;
	while(primul!=NULL)
	{
		p=primul;
		primul=primul->urmator;
		delete p;
	}
}

void Listac::ListaVida()
{
	Modificare();
	primul=ultimul=NULL;
}

int Listac::EsteVida()
{
	if(primul==NULL&&ultimul==NULL)
		return 1;
	else
		return 0;
}

int Listac::Lungime()
{
	if(EsteVida())
		return 0;
	if(primul==ultimul)
		return 1;

	int l=0;
	Nodc *p;
	for(p=primul;p!=NULL;p=p->urmator)
		l++;
	return l;
}

void Listac::Modificare()
{ 
	modificare=true;
}

bool Listac::getModificare()
{
	return modificare;
}

void Listac::setModificare(bool val)
{
	modificare=val;
}

void Listac::InsereazaInFata(Nodc *nod_de_legatura, Nodc *nod_de_inserat)
{
	Modificare();
	if(nod_de_legatura!=NULL&&nod_de_inserat!=NULL)
		if(nod_de_legatura->precedent==NULL)
		{
			nod_de_inserat->urmator=nod_de_legatura;
			nod_de_legatura->precedent=nod_de_inserat;
		}
		else
		{
			nod_de_inserat->precedent=nod_de_legatura->precedent;
			nod_de_legatura->precedent->urmator=nod_de_inserat;
			nod_de_inserat->urmator=nod_de_legatura;
			nod_de_legatura->precedent=nod_de_inserat;
		}
}

void Listac::InsereazaDupa(Nodc *nod_de_legatura, Nodc *nod_de_inserat)
{
	Modificare();
	if(nod_de_legatura!=NULL&&nod_de_inserat!=NULL)
		if(nod_de_legatura->urmator==NULL)
		{
			nod_de_legatura->urmator=nod_de_inserat;
			nod_de_inserat->precedent=nod_de_legatura;
		}
		else
		{
			nod_de_inserat->urmator=nod_de_legatura->urmator;
			nod_de_legatura->urmator->precedent=nod_de_inserat;
			nod_de_inserat->precedent=nod_de_legatura;
			nod_de_legatura->urmator=nod_de_inserat;
		}
}

void Listac::AdaugaContact(Contact &c, char t)
{
	Modificare();
	Nodc *p;
	Nodc *q=new Nodc;

	q->informatie=&c;
	q->urmator=NULL;
	q->precedent=NULL;
	q->setTip(t);


	if(EsteVida())
		primul=ultimul=q;
	else
	{
		for(p=primul;(p!=NULL)&&(strcmp(p->informatie->getNume(),q->informatie->getNume())<0);p=p->urmator);
		
		if(p==NULL)
		{
			InsereazaDupa(ultimul,q);
			ultimul=q;
		}
		else
		{
			if(strcmp(p->informatie->getNume(),q->informatie->getNume())>0)
			{
				InsereazaInFata(p,q);
				if(p==primul)
					primul=q;
			}
			else
				if(strcmp(p->informatie->getNume(),q->informatie->getNume())==0)
				{	
					if(strcmp(p->informatie->getPrenume(),q->informatie->getPrenume())<0)
					{
						InsereazaDupa(p,q);
						if(p==ultimul)
							ultimul=q;
					}
					else
						if(strcmp(p->informatie->getPrenume(),q->informatie->getPrenume())>0)
						{
							InsereazaInFata(p,q);
							if(p==primul)
								primul=q;
						}
						else
							if(strcmp(p->informatie->getPrenume(),q->informatie->getPrenume())==0)
							{
								if(strcmp(p->informatie->getNrTel(),q->informatie->getNrTel())<0)
								{
									InsereazaDupa(p,q);
									if(p==ultimul)
										ultimul=q;
								}
								else
									if(strcmp(p->informatie->getNrTel(),q->informatie->getNrTel())>0)
									{
										InsereazaInFata(p,q);
										if(p==primul)
											primul=q;
									}
							}
				}
		}
	}
}

void Listac::AdaugaContact()
{
	char r=' ';
	char t=' ';
	char s[51];
	strcpy(s,"");

	cout<<"Ce tip de contact adaugati? (a=Acquaintance/c=Colleague/n=Contact/f=Friend)\n";	
	while(!(r=='a'||r=='c'||r=='n'||r=='f'))
	{
		cout<<"Raspuns: ";
		cin>>r;
		t=r;
	}

	if(r=='a')
	{
		Acquaintance *a=new Acquaintance;
		cout<<"Nume: "; cin>>s; a->setNume(s);
		cout<<"Prenume: "; cin>>s ; a->setPrenume(s);
		cout<<"Telefon: "; cin>>s ; a->setNrTel(s);
		cout<<"Profesie: "; cin>>s ; a->setAtribut(s);
		AdaugaContact(*a,t);
	}
	else
		if(r=='c')
		{
			Colleague *a=new Colleague;
			cout<<"Nume: "; cin>>s ; a->setNume(s);
			cout<<"Prenume: "; cin>>s ; a->setPrenume(s);
			cout<<"Telefon: "; cin>>s ; a->setNrTel(s);
			cout<<"Categorie: "; cin>>s ; a->setAtribut(s);
			AdaugaContact(*a,t);
		}
		else
			if(r=='f')
			{
				Friend *a=new Friend;
				cout<<"Nume: "; cin>>s ; a->setNume(s);
				cout<<"Prenume: "; cin>>s ; a->setPrenume(s);
				cout<<"Telefon: "; cin>>s ; a->setNrTel(s);
				cout<<"Data: "; cin>>s ; a->setAtribut(s);
				AdaugaContact(*a,t);
			}
			else
				if(r=='n')
				{
					Contact *a=new Contact;
					cout<<"Nume: "; cin>>s ; a->setNume(s);
					cout<<"Prenume: "; cin>>s ; a->setPrenume(s);
					cout<<"Telefon: "; cin>>s ; a->setNrTel(s);
					AdaugaContact(*a,t);
				}
}

void Listac::StergeContact()
{
	Modificare();

	if(EsteVida())
		cout<<"Stiva este vida. Niciun contact de sters.\n";
	else
	{
		Nodc* nod_de_scos;
		int i;
		for(nod_de_scos=primul,i=0;i<p-1&&nod_de_scos!=NULL;i++,nod_de_scos=nod_de_scos->urmator);
		if(nod_de_scos==primul)
		{
			primul=nod_de_scos->urmator;
			if(primul!=NULL)
				primul->precedent=NULL;
		}
		else
			if(nod_de_scos==ultimul)
			{
				ultimul=nod_de_scos->precedent;
				if(ultimul!=NULL)
					ultimul->urmator=NULL;
			}
			else
			{
				nod_de_scos->urmator->precedent=nod_de_scos->precedent;
				nod_de_scos->precedent->urmator=nod_de_scos->urmator;
			}
		delete nod_de_scos;
	}
}


//functia Salveaza()
//se formeaza numele fisierului corespunzator proprietarului agendei (nume!prenume.txt)
//se apeleaza functia de salvare mai intai pentru owner (care salveaza pe langa nume si prenume si numarul de telefon)
//apoi pentru fiecare contact din lista, se apeleaza functia de salvare specifica (ce difera prin atributul special)
//se semnaleaza faptul ca aceasta lista nu are modificari prin schimbarea valorii de adevar a date membru : modificare
void Listac::Salveaza()
{
	char fisier[100];
	strcpy(fisier,ownerContact.getNume());
	strcat(fisier,"!");
	strcat(fisier,ownerContact.getPrenume());
	strcat(fisier,".txt");
		
	Nodc *p;
	
	ofstream fout(fisier);

	ownerContact.Salveaza(fisier);

	for(p=primul;p!=NULL;p=p->urmator)
	{
		p->informatie->Salveaza(fisier);
	}
	fout.close();
	modificare=false;
}

void Listac::Incarca(char *fisier)
{
	char tip;
	char linie[100];
		
	ifstream fin(fisier,ifstream::in);
	
	fin.getline(linie,100);
	
	ownerContact.Incarca(linie+2);
	
	while(fin.getline(linie,100))
	{
		Contact *c=new Contact;
		Acquaintance *a=new Acquaintance;
		Colleague *cl=new Colleague;
		Friend *f=new Friend;

		tip=linie[0];
		strcpy(linie,linie+2);

		if(tip=='n')
		{
			c->Incarca(linie);
			AdaugaContact(*c,tip);
		}

		if(tip=='a')
		{
			a->Incarca(linie);
			AdaugaContact(*a,tip);
		}
		
		if(tip=='c')
		{
			cl->Incarca(linie);
			AdaugaContact(*cl,tip);
		}

		if(tip=='f')
		{
			f->Incarca(linie);
			AdaugaContact(*f,tip);
		}
	}
	fin.close();
}

int Listac::getP()
{
	return p;
}

void Listac::setP(int a)
{
	p=a%(Lungime()+1);
	if(p<0)
		p=Lungime();
	if(p==0)
		p=Lungime();
}

Nodc *Listac::getContact(int pozitie)
{
	Nodc *p;
	int i;

	p=primul;
	for(i=1;(i<pozitie)&&p!=NULL;i++,p=p->urmator);
	return p;
}

Listac *Listac::Filtrare()
{
	char criteriu[15];
	strcpy(criteriu,"");

	char t=' ';
	while(strcmp(criteriu,"Tip")!=0&&strcmp(criteriu,"Retea")!=0&&strcmp(criteriu,"Numar telefon")!=0)
	{
		cout<<"\nCriteriul de filtrare: (tip/retea/numar telefon)\n";
		cin>>criteriu;
		criteriu[0]=toupper(criteriu[0]);
		cout<<criteriu;
	}
	
	Listac *f=new Listac;
	f->ownerContact=this->ownerContact;
	Nodc *p;

	if(!strcmp(criteriu,"Tip"))
	{
		cout<<"Tipul de contact: (a/c/f/n)";
		cin>>t;

		for(p=primul;p!=NULL;p=p->urmator)
			if(p->getTip()==t)
				f->AdaugaContact(*(p->informatie),t);
		return f;
	}
	else
		if(!strcmp(criteriu,"Retea"))
		{
			for(p=primul;p!=NULL;p=p->urmator)
				if(p->informatie->getNrTel()[2]==ownerContact.getNrTel()[2]&&p->informatie->getNrTel()[3]==ownerContact.getNrTel()[3])
					f->AdaugaContact(*(p->informatie),t);
			return f;
		}
		else
		{
			char data[20];
			strcpy(data,""); cout<<"Data: "; cin>>data;
			
			char c;
			for(p=primul;p!=NULL;p=p->urmator)
			{
				c=p->getTip();
				if(c=='f')
				{
					if(!strcmp(p->informatie->getAtribut(),data))
						f->AdaugaContact(*(p->informatie),t);
				}
			}
			return f;
		}
	return f;
}

Listac *Listac::Cautare()
{
	char criteriu[41];
	strcpy(criteriu,"");

	while(strcmp(criteriu,"")==0)
	{
		cout<<"Introduceti un criteriu de cautare (nume sau prenume sau ambele-separate prin spatiu- sau numar de telefon).\n";
		cin>>criteriu;
	}

	Listac *l=new Listac;
	l->ownerContact=this->ownerContact;
	
	Nodc *p;
	for(p=primul;p!=NULL;p=p->urmator)
	{
		Nodc *q=new Nodc;
		q->informatie=p->informatie;
		q->precedent=NULL;
		q->urmator=NULL;
		q->setTip(p->getTip());

		char nume_c[42];
		strcpy(nume_c,q->informatie->getNume()); strcat(nume_c," "); strcat(nume_c,q->informatie->getPrenume());
		if(strstr(q->informatie->getNume(),criteriu)!=NULL||strstr(q->informatie->getPrenume(),criteriu)!=NULL||strstr(nume_c,criteriu)!=NULL||strstr(q->informatie->getNrTel(),criteriu)!=NULL)
			if(l->EsteVida())
			{
				l->ultimul=l->primul=q;
			}
			else
			{
				l->ultimul->urmator=q;
				q->precedent=l->ultimul;
				l->ultimul=q;
			}
	}
	return l;
}

Nodo::Nodo()
{
	informatie=new Listac;
	urmator=NULL;
	precedent=NULL;
}

Listao::Listao()
{
	poz=1;
	nr_owneri=0;
	primul=NULL;
	ultimul=NULL;
}

Listao::~Listao()
{
	Nodo *p;
	while(primul!=NULL)
	{
		p=primul;
		primul=primul->urmator;
		delete p;
	}	
}

void Listao::ListaVida()
{
	primul=ultimul=NULL;
}

int Listao::EsteVida()
{
	if(primul==NULL&&ultimul==NULL)
		return 1;
	else
		return 0;
}

int Listao::Lungime()
{
	if(EsteVida())
		return 0;
	if(primul==ultimul)
		return 1;

	int l=0;
	Nodo *p;
	for(p=primul;p!=NULL;p=p->urmator)
		l++;
	return l;
}

void Listao::setNrOwneri(int v)
{
	nr_owneri=v;
}

int Listao::getNrOwneri()
{
	return nr_owneri;
}

void Listao::setPoz(int v)
{
	poz=v%(nr_owneri+1);
	if(poz<0)
		poz=nr_owneri;
	if(poz==0)
		poz=1;
}

int Listao::getPoz()
{
	return poz;
}

void Listao::InsereazaInaintePr(Nodo *nod_de_legatura, Nodo *nod_de_inserat)
{
	if(nod_de_legatura!=NULL&&nod_de_inserat!=NULL)
		if(nod_de_legatura->precedent==NULL)
		{
			nod_de_inserat->urmator=nod_de_legatura;
			nod_de_legatura->precedent=nod_de_inserat;
		}
		else
		{
			nod_de_inserat->precedent=nod_de_legatura->precedent;
			nod_de_legatura->precedent->urmator=nod_de_inserat;
			nod_de_inserat->urmator=nod_de_legatura;
			nod_de_legatura->precedent=nod_de_inserat;
		}
}

void Listao::InsereazaDupaPr(Nodo *nod_de_legatura, Nodo *nod_de_inserat)
{
	if(nod_de_legatura!=NULL&&nod_de_inserat!=NULL)
		if(nod_de_legatura->urmator==NULL)
		{
			nod_de_legatura->urmator=nod_de_inserat;
			nod_de_inserat->precedent=nod_de_legatura;
		}
		else
		{
			nod_de_inserat->urmator=nod_de_legatura->urmator;
			nod_de_legatura->urmator->precedent=nod_de_inserat;
			nod_de_inserat->precedent=nod_de_legatura;
			nod_de_legatura->urmator=nod_de_inserat;
		}
}

void Listao::AdaugaAgenda(Listac *agenda)
{

	nr_owneri++;
	Nodo *p;
	Nodo *q=new Nodo;
	
	q->precedent=NULL;
	q->urmator=NULL;
	q->informatie=agenda;

	if(EsteVida())
		primul=ultimul=q;
	else
	{
		for(p=this->primul;(p!=NULL)&&(strcmp(p->informatie->ownerContact.getNume(),q->informatie->ownerContact.getNume())<0);p=p->urmator);
		
		if(p==NULL)
		{
			InsereazaDupaPr(ultimul,q);
			ultimul=q;
		}
		else
		{
			if(strcmp(p->informatie->ownerContact.getNume(),q->informatie->ownerContact.getNume())>0)
			{
				InsereazaInaintePr(p,q);
				if(p==primul)
					primul=q;
			}
			else
				if(strcmp(p->informatie->ownerContact.getNume(),q->informatie->ownerContact.getNume())==0)
				{	
					if(strcmp(p->informatie->ownerContact.getPrenume(),q->informatie->ownerContact.getPrenume())<0)
					{
						InsereazaDupaPr(p,q);
						if(p==ultimul)
							ultimul=q;
					}
					else
						if(strcmp(p->informatie->ownerContact.getPrenume(),q->informatie->ownerContact.getPrenume())>0)
						{
							InsereazaInaintePr(p,q);
							if(p==primul)
								primul=q;
						}
						else
							if(strcmp(p->informatie->ownerContact.getPrenume(),q->informatie->ownerContact.getPrenume())==0)
							{
								if(strcmp(p->informatie->ownerContact.getNrTel(),q->informatie->ownerContact.getNrTel())<0)
								{
									InsereazaDupaPr(p,q);
									if(p==ultimul)
										ultimul=q;
								}
								else
									if(strcmp(p->informatie->ownerContact.getNrTel(),q->informatie->ownerContact.getNrTel())>0)
									{
										InsereazaInaintePr(p,q);
										if(p==primul)
											primul=q;
									}
							}
				}
		}
	}
}

void Listao::StergeAgenda()
{
	Nodo *nod_de_scos;
	nod_de_scos=primul;
	int i=1;
	for(;i<poz&&nod_de_scos!=NULL;i++,nod_de_scos=nod_de_scos->urmator);
	if(nr_owneri>0)
		nr_owneri--;

	if(EsteVida())
		cout<<"Lista este vida. Niciun proprietar de sters.\n";
	else
	{
		if(nod_de_scos==primul)
		{
			primul=nod_de_scos->urmator;
			if(primul!=NULL)
				primul->precedent=NULL;
		}
		else
			if(nod_de_scos==ultimul)
			{
				ultimul=nod_de_scos->precedent;
				if(ultimul!=NULL)
					ultimul->urmator=NULL;
			}
			else
			{
				nod_de_scos->urmator->precedent=nod_de_scos->precedent;
				nod_de_scos->precedent->urmator=nod_de_scos->urmator;
			}
	}
	delete nod_de_scos;
}

Listac *Listao::getAgenda(int pozitie)
{
	Nodo *p;
	int i;
	p=this->primul;
	for(i=1,p=primul;(i<pozitie)&&(p!=ultimul);i++,p=p->urmator);
	return p->informatie;
}

//functia Start()
//aceasta functie preia detaliile din fisierul Proprietari.txt, le transforma in numele unui fisier in care se gaseste
//agenda cu contacte a proprietarului respectiv, dupa care se incarca agenda noua din fisier, iar apoi se adauga in 
//lista de agende
void Listao::Start()
{
	ifstream fin("Proprietari.txt");
	
	char linie[100];

	while(fin.getline(linie,100))
	{
		//se incepe traducerea detaliilor in numele unui fisier
		char fisier[100];
		Listac *agenda_noua=new Listac;
		char *cuvant;

		cuvant=strtok(linie,"|");
		if(cuvant!=NULL)
			strcpy(fisier,cuvant);
		
		strcat(fisier,"!");

		if(cuvant!=NULL) cuvant=strtok(NULL,"|");
		if(cuvant!=NULL)
			strcat(fisier,cuvant);
		strcat(fisier,".txt");
		//s-a format numele fisierului

		agenda_noua->Incarca(fisier);//se incarca agenda din fisierul respectiv
		this->AdaugaAgenda(agenda_noua);//se adauga agenda in lista de agende
	}
	fin.close();
}


//functia Salveaza()
//se deschide fisierul standard pt lista de agende : Proprietari.txt, apoi se pargurge fiecare lista,
//se salveaza in Proprietari.txt detaliile proprietarului sub forma nume|prenume
//apoi se apeleaza functia de salvare si pentru agende

void Listao::Salveaza()
{
	Nodo *p;
	
	ofstream fout("Proprietari.txt");

	for(p=primul;p!=NULL;p=p->urmator)
	{
		fout<<p->informatie->ownerContact.getNume()<<"|"<<p->informatie->ownerContact.getPrenume()<<"\n";
		p->informatie->Salveaza();
	}
	fout.close();
}