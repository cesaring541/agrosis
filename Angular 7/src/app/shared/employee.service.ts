import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  formData  : Employee;
  list : Employee[];
  readonly rootURL ="http://localhost:7741/api"

  constructor(private http : HttpClient) { }

  postEmployee(formData : Employee){
   return this.http.post(this.rootURL+'/clntes',formData);
    
  }

  refreshList(){
    this.http.get(this.rootURL+'/clntes')
    .toPromise().then(res => this.list = res as Employee[]);
  }

  putEmployee(formData : Employee){
    return this.http.put(this.rootURL+'/clntes/'+formData.clntes_idntfccion,formData);
     
   }

   deleteEmployee(formData : Employee){
    return this.http.delete(this.rootURL+'/clntes/'+formData);
   }
}
