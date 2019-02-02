import { Component, OnInit, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { RepositoryService } from '../../shared/services/repository.service';
import { ProductItemComponent } from '../../shared/product-item/product-item.component';
import { ProductReviewService } from '../../admin-tools/services/product-review.service';
import { config } from 'src/app/config/pages-config';
import { Router } from '@angular/router';
import { UtilitiesService } from 'src/app/shared/services/utilities.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-add-item-for-review',
  templateUrl: './add-item-for-review.component.html',
  styleUrls: ['./add-item-for-review.component.css']
})
export class AddItemForReviewComponent implements OnInit {
  reviewForm: FormGroup;
  imageAdded = false;
  baseUrl = environment.filesBaseUrl;
  @ViewChild('itemForReview') item: ProductItemComponent;
  constructor(private fb: FormBuilder,
    private repositoryService: RepositoryService,
    private productReviewService: ProductReviewService,
    private router: Router,
    private util: UtilitiesService) { }

  ngOnInit() {
    this.reviewForm = this.fb.group({
      'id': [0],
      'name': ['', Validators.required] ,
      'description': [''],
      'profilePictureFile': [],
      'profilePicture': ['']

    });
    if (this.productReviewService.productReviewToUpdate) {
      this.reviewForm.setValue(this.productReviewService.productReviewToUpdate);
    }
  }
  submit() {
    if (this.reviewForm.valid) {
      this.productReviewService.productReviewToUpdate ? this.update() : this.create(); 
    }
  }
  create() {
    const formData = new FormData();
    this.util.appendFormData(formData, this.reviewForm.value);
    this.repositoryService.create('itemsreview', formData).subscribe(data => {
      alert('success');
      this.router.navigate([config.admin.itemReviewList.route]);
    }, error => {
      alert(error);
    });
  }

  update() {
    const formData = new FormData();
    this.util.appendFormData(formData, this.reviewForm.value);
    this.repositoryService.update('itemsreview/' + this.productReviewService.productReviewToUpdate.id, 
    formData).subscribe(data => {
      this.productReviewService.productReviewToUpdate = null;
      alert('success');
      this.router.navigate([config.admin.itemReviewList.route]);      
    }, error => {
      alert(error);
    });
  }

  onFileSelect(file) {
    this.reviewForm.controls['profilePictureFile'].setValue(file);
    const reader = new FileReader();
    reader.onload = (e: any) => {
      this.item.cardImage = e.target.result;
    };
    reader.readAsDataURL(file);
    this.imageAdded = true;
  }

}
