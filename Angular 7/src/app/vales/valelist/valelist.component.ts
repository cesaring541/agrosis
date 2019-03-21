import { Component, OnInit } from '@angular/core';
import { ValesService } from 'src/app/shared/vales.service';
import { Vale } from 'src/app/shared/vale.model';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-valelist',
  templateUrl: './valelist.component.html',
  styleUrls: ['./valelist.component.css']
})
export class ValelistComponent implements OnInit {

  constructor(private service:ValesService,
    private toastr:ToastrService) { }

    ngOnInit() {
      this.service.refreshList();
    }
    populateForm(val: Vale) {
      this.service.formData = Object.assign({}, val);
    }
    onDelete(id: Vale) {
      if (confirm('Are you sure to delete this record?')) {
        this.service.deleteEmployee(id).subscribe(res => {
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'EMP. Register');
        });
      }
    }
  
}
