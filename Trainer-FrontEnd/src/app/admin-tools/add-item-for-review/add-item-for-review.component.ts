import { Component, OnInit, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { RepositoryService } from '../../shared/services/repository.service';
import { ProductItemComponent } from '../../shared/product-item/product-item.component';
import { ProductReviewService } from '../../admin-tools/services/product-review.service';

@Component({
  selector: 'app-add-item-for-review',
  templateUrl: './add-item-for-review.component.html',
  styleUrls: ['./add-item-for-review.component.css']
})
export class AddItemForReviewComponent implements OnInit {
  reviewForm: FormGroup;
  imageAdded = false;
  @ViewChild('itemForReview') item: ProductItemComponent;
  constructor(private fb: FormBuilder,
    private repositoryService: RepositoryService,
    private productReviewService: ProductReviewService) { }

  ngOnInit() {
    this.reviewForm = this.fb.group({
      'id': [''],
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
    this.repositoryService.create('itemsreview', this.prepareData(this.reviewForm.value)).subscribe(data => {
      alert('success');
    }, error => {
      alert(error);
    });
  }

  update() {
    this.repositoryService.update('itemsreview/' + this.productReviewService.productReviewToUpdate.id, 
    this.prepareData(this.reviewForm.value)).subscribe(data => {
      this.productReviewService.productReviewToUpdate = null;
      alert('success');
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

  prepareData(itemData) {
    const formData = new FormData();
    formData.append('name', itemData.name);
    formData.append('profilePictureFile', itemData.profilePictureFile);
    // formData.append('createdAt', itemData.createdAt ? itemData.createdAt : new Date().toISOString());
    // formData.append('createdBy', itemData.createdBy ? itemData.createdBy : 'admin');
    formData.append('profilePicture', itemData.profilePicture ? itemData.profilePicture : '');
    formData.append('description', itemData.description);
    
    return formData;
  }

}