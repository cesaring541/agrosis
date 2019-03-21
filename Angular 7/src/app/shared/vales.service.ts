import { Injectable } from '@angular/core';
import { Vale } from './vale.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ValesService {
  formData  : Vale;
  list : Vale[];
  readonly rootURL ="http://localhost:7741/api"
  constructor(private http : HttpClient) {}
  postEmployee(formData : Vale){
    return this.http.post(this.rootURL+'/enc_vles',formData);
     
   }
 
   refreshList(){
     this.http.get(this.rootURL+'/enc_vles')
     .toPromise().then(res => this.list = res as Vale[]);
   }
 
   putEmployee(formData : Vale){
     return this.http.put(this.rootURL+'/enc_vles/'+formData.clntes_idntfccion,formData);
      
    }
 
    deleteEmployee(formData : Vale){
     return this.http.delete(this.rootURL+'/enc_vles/'+formData);
    }
}
