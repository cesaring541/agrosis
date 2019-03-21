import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employees.component';
import { EmployeeComponent } from './employees/employee/employee.component';
import { EmployeeListComponent } from './employees/employee-list/employee-list.component';
import { EmployeeService } from './shared/employee.service';
import { HomeComponent } from './home/home.component';
//routing app
import { AppRoutingModule } from './app-routing.module';
import { ValesComponent } from './vales/vales.component';
import { ValeComponent } from './vales/vale/vale.component';
import { MatTableModule, MatPaginatorModule, MatSortModule } from '@angular/material';
import { ValelistComponent } from './vales/valelist/valelist.component';
import {NgxPaginationModule} from 'ngx-pagination'; 



@NgModule({
  declarations: [
    AppComponent,
    EmployeesComponent,
    EmployeeComponent,
    EmployeeListComponent,
    HomeComponent,
    ValesComponent,
    ValeComponent,
    ValelistComponent,
    
    
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ToastrModule.forRoot(), 
    AppRoutingModule, MatTableModule, MatPaginatorModule, MatSortModule, 
    NgxPaginationModule
    
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
