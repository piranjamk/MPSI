///////////////////////////////////////////////////////////
//  Ster_ZapiszDaneoKredycie.cs
//  Implementation of the Class Ster_ZapiszDaneoKredycie
//  Generated by Enterprise Architect
//  Created on:      06-kwi-2023 23:57:33
//  Original author: Marcin Kurzawski
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Dane;
public class Ster_ZapiszDaneoKredycie {

	private char idWniosek;
	private char Informacje;

	public Ster_ZapiszDaneoKredycie(){

	}

	~Ster_ZapiszDaneoKredycie(){

	}

	public Kredyt Kredyt{
		get{
			return m_Kredyt;
		}
		set{
			m_Kredyt = value;
		}
	}

	public void zapiszDaneOKredycie(){

	}

}//end Ster_ZapiszDaneoKredycie