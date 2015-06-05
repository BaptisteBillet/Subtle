using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum Hashtag
{
	ANIMAL,
	OBJET,
	PLANTE
}

class Theme 
{ 
	string m_name;
	List<Hashtag> hashTagList;

	public Theme()
	{
		m_name = "DefaultName";
		hashTagList = new List<Hashtag>();
	}

	public void AddTag(Hashtag tag)
	{
		if(!hashTagList.Contains(tag))
		{
			hashTagList.Add(tag);
		}
	}

	public void SetName(string name)
	{
		m_name = name;
	}

	public string GetName()
	{
		return m_name;
	}
}