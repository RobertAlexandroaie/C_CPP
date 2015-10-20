#ifndef CONTROLLER_CONTACT_H
#define CONTROLLER_CONTACT_H
#include "model-contact.h" 
#include "view-contact.h"
#include "controller-contact-modify.h"

using namespace std;

class ControllerContact
{
private:
	Contact *model;
	ViewContact *view;
public:
	ControllerContact(Contact *newModel)
	{
		model = newModel;
		
	}
public:
	void setView(ViewContact *newView)
	{
		view = newView;
	}
public:
	void listen()
	{
		ControllerContactModify ccModify(model);
		int option = view->getUserAction();
		switch (option)
		{
			case 0: finish();
				break;
			case 1: 
				ccModify.listen();
				break;
			default: exit(1);
		}
	}

public:
	void finish()
	{
		// nothing
	}
};

#endif 
